using System;
using System.Collections.Generic;

class ControladorJogo
{
    public void IniciarJogo() {
        string path = "gameConfig.txt";
        LeitorTxt leitor = new LeitorTxt(path);
        ITabuleiro tabuleiro = new Tabuleiro();
        tabuleiro.MontarTabuleiro(leitor.CarregarArquivo());
        List<IJogador> jogadores = new List<IJogador>();
        IJogador impulsivo = new Impulsivo();
        IJogador exigente = new Exigente();
        IJogador cauteloso = new Cauteloso();
        IJogador aleatorio = new Aleatorio();
    }

    
}