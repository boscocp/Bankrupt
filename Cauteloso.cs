using System;

public class Cauteloso : Jogador {
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        ITerreno terreno = tabuleiro.GetTerrenos()[_posicao];
        if(terreno.ValorVenda - _coins >= 80) this.TentarComprar(tabuleiro);
        this.VerificarSePerdeu();
    }
}