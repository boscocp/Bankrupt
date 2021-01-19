using System;

public class Impulsivo : Jogador {
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        this.TentarComprar(tabuleiro);
        this.VerificarSePerdeu();
    }
}