using System;

public class Aleatorio : Jogador {
    public Aleatorio()
    {
        _nome = "Aleatorio";
    }
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        this.VerificarSePerdeu();
        if(this.RolarDado() > 3) this.TentarComprar(tabuleiro);
    }
}