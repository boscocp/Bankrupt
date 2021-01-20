using System;
using System.Collections.Generic;
using System.Linq;

class GameController
{
    int turns = 0;
    int timeout = 0;
    public string StartGame()
    {
        string path = "gameConfig.txt";
        ReaderTxt reader = new ReaderTxt(path);
        IBoard board = new Board();
        List<IPlayer> players = new List<IPlayer>();
        IPlayer impulsive = new Impulsive();
        IPlayer rigorous = new Rigorous();
        IPlayer cautious = new Cautious();
        IPlayer randon = new Randon();

        board.SetupBoard(reader.LoadFile());
        players.Add(impulsive);
        players.Add(rigorous);
        players.Add(cautious);
        players.Add(randon);

        return GameLoop(players, board);
    }

    public int GetTurns()
    {
        return turns;
    }

    public int GetTimeout()
    {
        return timeout;
    }

    public string GameLoop(List<IPlayer> players, IBoard board)
    {
        int counter = 1000;
        List<IPlayer> playersAux = players;
        while (players.Count > 0 )
        {
            foreach (Player player in players)
            {
                if (players.Count == 1)
                {
                    turns = 1000 - counter;
                    return player._name + " has won";
                }
                player.Play(board);

            }
            players.RemoveAll(x => x.Over);
            if (players.Count <= 0) 
            {
                turns = 1000 - counter;
                return Tiebreaker(playersAux);
            }
            playersAux.RemoveAll(x => x.Over);
            counter--;
            if (counter <= 0)
            {
                turns = 1000 - counter;
                timeout = 1;
                return Tiebreaker(players);
            }
        }
        turns = 1000 - counter;
        return Tiebreaker(players);
    }

    private static string Tiebreaker(List<IPlayer> players)
    {
        List<IPlayer> playersAux = players.OrderByDescending(x => x.Coins).ToList();

        int maisMoeda = playersAux[0].Coins;
        playersAux.RemoveAll(x => x.Coins < maisMoeda);
        players.RemoveAll(x => x.Coins < maisMoeda);
        if (playersAux.Count > 1)
        {
            return players[players.Count - 1].Name + " won";
        }
        else
        {
            return playersAux[0].Name + " won";
        }
    }
}