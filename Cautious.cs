using System;

public class Cautious : Player {
    public Cautious ()
    {
        _name = "Cautious";
    }
    public override void Play (IBoard board) 
    {
        this.WalkOnBoard(board);
        this.IsOver();
        ITerrain terrain = board.GetTerrains()[_position];
        if(_coins - terrain.ValueSale >= 80) this.TryBuy(board);
    }
}