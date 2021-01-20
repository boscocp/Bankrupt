using System;

class Terrain : ITerrain
{
    private int _valueSale;
    private int _valueRent;
    private IPlayer _player;
    private bool _hasOwner = false;

    public int ValueSale { get => _valueSale;  }
    public int ValueRent { get => _valueRent;  }
    public IPlayer PlayerOwner { get => _player; }
    public bool HasOwner { get => _hasOwner; set => _hasOwner = value; }

    public Terrain (int valueSale, int valueRetn)
    {
        _valueSale = valueSale;
        _valueRent = valueRetn;
    }

    public void SetOwner(IPlayer jogador)
    {
        _player = jogador;
        HasOwner = true;
    }
}
