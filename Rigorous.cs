using System;

public class Rigorous : Player {
    public Rigorous ()
    {
        _name = "Rigorous";
    }
    public override void Play (IBoard tabuleiro) 
    {
        this.WalkOnBoard(tabuleiro);
        this.IsOver();
        ITerrain terreno = tabuleiro.GetTerrains()[_position];
        if(terreno.ValueRent> 50) this.TryBuy(tabuleiro);
    }
}