using System;

public abstract class Player : IPlayer
{
    public string _name;
    public int _wins;
    protected int _coins = 300;
    public int Coins { get => _coins; set => _coins = value; }
    protected int _position = 0;
    protected bool _over = false;
    public bool Over { get => _over; }

    public string Name { get =>_name; }

    public abstract void Play(IBoard tabuleiro);

    public void TryBuy(IBoard tabuleiro)
    {
        ITerrain terreno = tabuleiro.GetTerrains()[_position];

        if (terreno.HasOwner == false && _coins >= terreno.ValueSale )
        {
            terreno.SetOwner(this);
            _coins -= terreno.ValueSale;
        }
    }

    public void IsOver()
    {
        if (_coins <= 0)
        {
            _over = true;
        }
    }

    public int RollDice()
    {
        Random randNum = new Random();
        int dice = randNum.Next(1, 6);
        return dice;
    }

    public void WalkOnBoard(IBoard board)
    {
        ITerrain terrain = board.GetTerrains()[_position];
        int dice = RollDice();
        int count = board.GetTerrains().Count;
        if (_position + dice > count - 1)
        {
            _position = dice + _position - count;
            PayDay();
        }
        else
        {
            _position += dice;
        }
        VerifyPayRent(terrain);
    }

    private void PayDay()
    {
        _coins += 100;
    }

    private void VerifyPayRent(ITerrain terreno)
    {
        if (terreno.PlayerOwner != this && terreno.HasOwner)
        {
            _coins -= terreno.ValueRent;
            terreno.PlayerOwner.Coins += terreno.ValueRent;
        }
    }
}