using System;

namespace Players
{
    public class Player
    {
        public string Name;
        public int Points;
        public string LastMove;

        public Player(int playerNum)
        {
            LastMove = "";
            Points = 0;

            Console.Write("Please type name of player " + playerNum + ": ");
            Name = Console.ReadLine();
            Console.WriteLine(Name + " - points: " + Points + " has been created.");
        }

        public void PrintNewTurn(int turn)
        {
            Console.WriteLine("Turn number " + turn + " begins for " + Name);
        }
    }
}