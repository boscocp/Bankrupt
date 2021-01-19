using System;
using System.Collections.Generic;

class Tabuleiro : ITabuleiro
{
    public List<ITerreno> _terrenos = new List<ITerreno> ();

    public List<ITerreno> GetTerrenos()
    {
        return _terrenos;
    }
    public void MontarTabuleiro(List<ITerreno> value)
    {
        _terrenos = value;
    }

}
