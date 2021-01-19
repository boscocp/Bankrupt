using System;

public class Exigente : Jogador {
    public Exigente ()
    {
        _nome = "Exigente";
    }
    public override void Jogar (ITabuleiro tabuleiro) 
    {
        this.AndarNoTabuleiro(tabuleiro);
        this.VerificarSePerdeu();
        ITerreno terreno = tabuleiro.GetTerrenos()[_posicao];
        if(terreno.ValorAluguel > 50) this.TentarComprar(tabuleiro);
    }
}