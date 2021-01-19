using System;

public abstract class Jogador : IJogador
{
    public string _nome;
    public int _vitorias;
    protected int _coins = 300;
    public int Coins { get => _coins; set => _coins = value; }
    protected int _posicao = 0;
    protected bool _perdeu = false;
    public bool Perdeu { get => _perdeu; }

    public string Nome { get =>_nome; }

    public abstract void Jogar(ITabuleiro tabuleiro);

    public void TentarComprar(ITabuleiro tabuleiro)
    {
        ITerreno terreno = tabuleiro.GetTerrenos()[_posicao];

        if (terreno.TemDono == false && _coins >= terreno.ValorVenda )
        {
            terreno.DefinirDono(this);
            _coins -= terreno.ValorVenda;
        }
    }

    public void VerificarSePerdeu()
    {
        if (_coins <= 0)
        {
            _perdeu = true;
        }
    }

    public int RolarDado()
    {
        Random randNum = new Random();
        int dado = randNum.Next(1, 6);
        return dado;
    }

    public void AndarNoTabuleiro(ITabuleiro tabuleiro)
    {
        ITerreno terreno = tabuleiro.GetTerrenos()[_posicao];
        int dado = RolarDado();
        int count = tabuleiro.GetTerrenos().Count;
        if (_posicao + dado > count - 1)
        {
            _posicao = dado + _posicao - count;
            PagarSalario();
        }
        else
        {
            _posicao += dado;
        }
        VerificarPagarAluguel(terreno);
    }

    private void PagarSalario()
    {
        _coins += 100;
    }

    private void VerificarPagarAluguel(ITerreno terreno)
    {
        if (terreno.JogadorDono != this && terreno.TemDono)
        {
            _coins -= terreno.ValorAluguel;
            terreno.JogadorDono.Coins += terreno.ValorAluguel;
        }
    }
}