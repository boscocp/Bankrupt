using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        int e = 0, c = 0, im = 0, a = 0;
        int rodadas = 0;
        int timeout = 0;
        for (int i = 0; i < 300; i++)
        {
            ControladorJogo jogo = new ControladorJogo();
            string partida = jogo.IniciarJogo();
            if ("Exigente ganhou" == partida)
            {
                e++;
            }
            else if ("Cauteloso ganhou" == partida)
            {
                c++;
            }
            else if ("Aleatorio ganhou" == partida)
            {
                a++;
            }
            else if ("Impulsivo ganhou" == partida)
            {
                im++;
            }
            rodadas += jogo.GetRodadas();
            timeout += jogo.GetTimeout();
        }
        rodadas = rodadas / 300;
        ImprimirRelatorio(e, c, im, a, rodadas, timeout);
    }

    private static void ImprimirRelatorio(int e, int c, int im, int a, int rodadas, int timeout)
    {
        List<Jogador> jogadoresRelatorio = new List<Jogador>();
        Jogador impulsivo = new Impulsivo();
        Jogador exigente = new Exigente();
        Jogador aleatorio = new Exigente();
        Jogador cauteloso = new Exigente();
        impulsivo._vitorias = im;
        exigente._vitorias = e;
        aleatorio._vitorias = a;
        cauteloso._vitorias = c;
        jogadoresRelatorio.Add(impulsivo);
        jogadoresRelatorio.Add(exigente);
        jogadoresRelatorio.Add(aleatorio);
        jogadoresRelatorio.Add(cauteloso);
        List<Jogador> l = jogadoresRelatorio.OrderByDescending(x => x._vitorias).ToList();

        Console.WriteLine("Impulsivo ganhou " + im + " vezes, " + (float)im / 3.2d + "% de vitoria");
        Console.WriteLine("Exigente ganhou " + e + " vezes " + (float)e / 3.2d + "% de vitoria");
        Console.WriteLine("Aleatorio ganhou " + a + " vezes " + (float)a / 3.2d + "% de vitoria");
        Console.WriteLine("Cauteloso ganhou " + c + " vezes " + (float)c / 3.2d + "% de vitoria");
        Console.WriteLine("Media de rodadas " + rodadas);
        Console.WriteLine("Rodadas timeout " + timeout);
        Console.WriteLine("Jogador que mais vence " + jogadoresRelatorio[0]._nome);
    }
}

