using System;

public class Exigente : Jogador {
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        ITerreno terreno = tabuleiro.GetTerrenos()[_posicao];
        if(terreno.ValorAluguel > 50) this.TentarComprar(tabuleiro);
        this.VerificarSePerdeu();
    }
}