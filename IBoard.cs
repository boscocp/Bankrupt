using System;
using System.Collections.Generic;

public interface IBoard
{
    List<ITerrain> GetTerrains();
    void SetupBoard(List<ITerrain> value);
}
