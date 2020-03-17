using System;
using System.Collections.Generic;
using Players;

namespace GameLoops
{
    public class GameLoop
    {
        public int MaxWinValue;
        public List<Player> Players;
        public int turn;

        public GameLoop()
        {
            Console.Write("Please set winning points value: ");
            MaxWinValue = Int32.Parse(Console.ReadLine());
            Players = new List<Player>();

            //add 2 players
            for (int i = 1; i <= 2; i++)
                Players.Add(new Player(i));

            //
        }
    }
}