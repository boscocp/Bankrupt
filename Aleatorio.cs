using System;

public class Aleatorio : Jogador {
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        if(this.RolarDado() > 3) this.TentarComprar(tabuleiro);
        this.VerificarSePerdeu();
    }
}