using System;

public class Impulsive : Player {
    public Impulsive()
    {
        _name = "Impulsive";
    }
    public override void Play (IBoard tabuleiro) 
    {
        this.WalkOnBoard(tabuleiro);
        this.IsOver();
        this.TryBuy(tabuleiro);
    }
}