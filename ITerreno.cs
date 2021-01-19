using System;

public interface ITerreno
{
   int ValorVenda { get; }
   int ValorAluguel { get; }
   IJogador JogadorDono { get; }
   bool TemDono { get; }
   void DefinirDono (IJogador jogador);
}