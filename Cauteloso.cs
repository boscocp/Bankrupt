using System;

public class Cauteloso : Jogador {
    public Cauteloso ()
    {
        _nome = "Cauteloso";
    }
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        this.VerificarSePerdeu();
        ITerreno terreno = tabuleiro.GetTerrenos()[_posicao];
        if(_coins - terreno.ValorVenda >= 80) this.TentarComprar(tabuleiro);
    }
}