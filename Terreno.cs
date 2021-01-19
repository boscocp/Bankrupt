using System;

class Terreno : ITerreno
{
    private int _valorVenda;
    private int _valorAluguel;
    private IJogador _jogador;
    private bool _temDono = false;

    public int ValorVenda { get => _valorVenda;  }
    public int ValorAluguel { get => _valorAluguel;  }
    public IJogador JogadorDono { get => _jogador; set => _jogador = value; }
    public bool TemDono { get => _temDono; set => _temDono = value; }

    public Terreno (int valorVenda, int valorAluguel)
    {
        _valorVenda = valorVenda;
        _valorAluguel = valorAluguel;
    }

    public void DefinirDono(IJogador jogador)
    {
        _jogador = jogador;
        TemDono = true;
    }
}
