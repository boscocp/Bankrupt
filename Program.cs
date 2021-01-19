using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        string path = "gameConfig.txt";
        LeitorTxt leitor = new LeitorTxt(path);
        ITabuleiro tabuleiro = new Tabuleiro();
        tabuleiro.MontarTabuleiro(leitor.CarregarArquivo());
        
        Jogador impulsivo = new Impulsivo();
        Console.WriteLine(impulsivo.Coins);
        impulsivo.Jogar(tabuleiro);
        Console.WriteLine(impulsivo.Coins);
        impulsivo.Jogar(tabuleiro);
        Console.WriteLine(impulsivo.Coins);
        impulsivo.Jogar(tabuleiro);
        Console.WriteLine(impulsivo.Coins);
        impulsivo.Jogar(tabuleiro);
        Console.WriteLine(impulsivo.Coins);
        impulsivo.Jogar(tabuleiro);
        Console.WriteLine(impulsivo.Coins);
        impulsivo.Jogar(tabuleiro);
        Console.WriteLine(impulsivo.Coins);
        impulsivo.Jogar(tabuleiro);
        Console.WriteLine(impulsivo.Coins);
    }
}

