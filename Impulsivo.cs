using System;

public class Impulsivo : Jogador {
    public Impulsivo()
    {
        _nome = "Impulsivo";
    }
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        this.VerificarSePerdeu();
        this.TentarComprar(tabuleiro);
    }
}