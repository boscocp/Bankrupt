using System;
using System.Collections.Generic;

public interface ITabuleiro
{
    List<ITerreno> GetTerrenos();
    void MontarTabuleiro(List<ITerreno> value);
}
