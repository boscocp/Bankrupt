using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        int rigorousWins = 0, cautiousWins = 0, impulsiveWins = 0, randonWins = 0;
        int turns = 0;
        int timeout = 0;
        for (int i = 0; i < 300; i++)
        {
            GameController game = new GameController();
            string partida = game.StartGame();
            if ("Rigorous has won" == partida)
            {
                rigorousWins++;
            }
            else if ("Cautious has won" == partida)
            {
                cautiousWins++;
            }
            else if ("Randon has won" == partida)
            {
                randonWins++;
            }
            else if ("Impulsive has won" == partida)
            {
                impulsiveWins++;
            }
            turns += game.GetTurns();
            timeout += game.GetTimeout();
        }
        turns = turns / 300;
        ImprimirRelatorio(rigorousWins, cautiousWins, impulsiveWins, randonWins, turns, timeout);
    }

    private static void ImprimirRelatorio(int e, int c, int im, int a, int turns, int timeout)
    {
        List<Player> playersReport = new List<Player>();
        Player impulsive = new Impulsive();
        Player rigorous = new Rigorous();
        Player randon = new Rigorous();
        Player cautious = new Rigorous();
        impulsive._wins = im;
        rigorous._wins = e;
        randon._wins = a;
        cautious._wins = c;
        playersReport.Add(impulsive);
        playersReport.Add(rigorous);
        playersReport.Add(randon);
        playersReport.Add(cautious);
        List<Player> l = playersReport.OrderByDescending(x => x._wins).ToList();

        Console.WriteLine("Impulsive has won " + im + " times, " + (float)im / 3.2d + "% of victory");
        Console.WriteLine("Rigorous has won " + e + " vezes " + (float)e / 3.2d + "% of victory");
        Console.WriteLine("Randon has won " + a + " vezes " + (float)a / 3.2d + "% of victory");
        Console.WriteLine("Cautious has won " + c + " vezes " + (float)c / 3.2d + "% of victory");
        Console.WriteLine("Average of turns: " + turns);
        Console.WriteLine("Turns with timeout: " + timeout);
        Console.WriteLine("player who won the most: " + playersReport[0]._name);
    }
}

