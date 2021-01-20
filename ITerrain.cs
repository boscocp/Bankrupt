using System;

public interface ITerrain
{
   int ValueSale{ get; }
   int ValueRent { get; }
   IPlayer PlayerOwner { get; }
   bool HasOwner { get; }
   void SetOwner (IPlayer player);
}