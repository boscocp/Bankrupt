using System;

public class Randon : Player {
    public Randon()
    {
        _name = "Randon";
    }
    public override void Play (IBoard board) 
    {
        this.WalkOnBoard(board);
        this.IsOver();
        if(this.RollDice() > 3) this.TryBuy(board);
    }
}