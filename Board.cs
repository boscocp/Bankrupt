using System;
using System.Collections.Generic;

class Board : IBoard
{
    public List<ITerrain> _terrenos = new List<ITerrain> ();

    public List<ITerrain> GetTerrains()
    {
        return _terrenos;
    }
    public void SetupBoard(List<ITerrain> value)
    {
        _terrenos = value;
    }

}
