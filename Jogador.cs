using System;

public abstract  class Jogador : IJogador
{
    protected int _coins = 300;
    public int Coins { get => _coins; set => _coins = value; }
    protected int _posicao = 0;
    protected bool _perdeu = false;
    public bool Perdeu { get => _perdeu; }

    public abstract void Jogar(ITabuleiro tabuleiro);

    public void TentarComprar(ITabuleiro tabuleiro)
    {
        ITerreno terreno = tabuleiro.GetTerrenos()[_posicao];
         
        if (terreno.TemDono == false )
        {
            tabuleiro.GetTerrenos()[_posicao].DefinirDono(this);
            _coins -= terreno.ValorVenda;
        } else if (terreno.JogadorDono != this)
        {
            _coins -= terreno.ValorAluguel;
        }
    }

    public void VerificarSePerdeu()
    {
        if(_coins <= 0) _perdeu = true;
    }

    public int RolarDado() 
    {
        Random randNum = new Random();
        int dado = randNum.Next(1,6);
        return dado;
    }

    public void AndarNoTabuleiro (ITabuleiro tabuleiro)
    {
        int dado = RolarDado();
        int count = tabuleiro.GetTerrenos().Count;
        Console.WriteLine(_posicao+" "+dado);
        if (_posicao + dado > count - 1) 
        {
            _posicao = dado + _posicao - count;
             Console.WriteLine(_posicao);
            _coins += 100;
        } else 
        {
            _posicao += dado;
        }
    }

}