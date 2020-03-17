using System;

namespace Players
{
    public class Player
    {
        public string Name;
        public int Points;

        public Player(int playerNum)
        {
            Console.WriteLine("Please type name of player " + playerNum + ".");
            Name = Console.ReadLine();

            Points = 0;

            Console.WriteLine(Name + " - points: " + Points + " has been created");
        }
    }
}