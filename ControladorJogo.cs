using System;
using System.Collections.Generic;
using System.Linq;

class ControladorJogo
{
    int rodadas = 0;
    int timeout = 0;
    public string IniciarJogo()
    {
        string path = "gameConfig.txt";
        LeitorTxt leitor = new LeitorTxt(path);
        ITabuleiro tabuleiro = new Tabuleiro();
        List<IJogador> jogadores = new List<IJogador>();
        IJogador impulsivo = new Impulsivo();
        IJogador exigente = new Exigente();
        IJogador cauteloso = new Cauteloso();
        IJogador aleatorio = new Aleatorio();

        tabuleiro.MontarTabuleiro(leitor.CarregarArquivo());
        jogadores.Add(impulsivo);
        jogadores.Add(exigente);
        jogadores.Add(cauteloso);
        jogadores.Add(aleatorio);

        return GameLoop(jogadores, tabuleiro);
    }

    public int GetRodadas()
    {
        return rodadas;
    }

    public int GetTimeout()
    {
        return timeout;
    }

    public string GameLoop(List<IJogador> jogadores, ITabuleiro tabuleiro)
    {
        int contador = 1000;
        List<IJogador> jAux = jogadores;
        while (jogadores.Count > 0 )
        {
            foreach (Jogador jogador in jogadores)
            {
                if (jogadores.Count == 1)
                {
                    rodadas = 1000 - contador;
                    return jogador._nome + " ganhou";
                }
                jogador.Jogar(tabuleiro);

            }
            jogadores.RemoveAll(x => x.Perdeu);
            if (jogadores.Count <= 0) 
            {
                rodadas = 1000 - contador;
                return CriterioDesempate(jAux);
            }
            jAux.RemoveAll(x => x.Perdeu);
            contador--;
            if (contador <= 0)
            {
                rodadas = 1000 - contador;
                timeout = 1;
                return CriterioDesempate(jogadores);
            }
        }
        rodadas = 1000 - contador;
        return CriterioDesempate(jogadores);
    }

    private static string CriterioDesempate(List<IJogador> jogadores)
    {
        List<IJogador> jAux = jogadores;
        jAux.OrderBy(x => x.Coins);

        int maisMoeda = jAux[jAux.Count - 1].Coins;
        jAux.RemoveAll(x => x.Coins < maisMoeda);
        jogadores.RemoveAll(x => x.Coins < maisMoeda);
        if (jAux.Count > 1)
        {
            return jogadores[jogadores.Count - 1].Nome + " ganhou";
        }
        else
        {
            return jAux[jAux.Count - 1].Nome + " ganhou";
        }
    }
}