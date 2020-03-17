/* ================*/
/* Maciej Labedzki */
/* =============== */

using System;
using Players;
using GameLoops;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        int lastChose = 0;

        //menu loop
        while (lastChose != 1)
        {
            //Intro
            Console.WriteLine("      Rock Paper Scissors       ");
            Console.WriteLine("");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("[1] Play a new game!");
            Console.WriteLine("[9] Exit Game");

            lastChose = Int32.Parse(Console.ReadLine());
            //ClearScreen
            Console.Clear();
            if (lastChose == 9) return;
        }

        //New Game Setup!
        GameLoop loop = new GameLoop();

        //get player input as text
        //string PlayerInput = Console.ReadLine();
        //Console.WriteLine(KeyPressed);

        return;
    }
}

public enum Moves
{
    Rock = 021,
    Paper = 102,
    Scissors = 210
}