/* ================*/
/* Maciej Labedzki */
/* =============== */

using System;
using System.Text.RegularExpressions;
using GameLoops;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        int lastChose = 0;

        //menu loop
        while (true)
        {
            //Print Menu
            Console.WriteLine("      Rock Paper Scissors       ");
            Console.WriteLine("");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("[1] Play a new game!");
            Console.WriteLine("[9] Exit Game");

            //Choose option - if string is not all numbers you cant parse
            string tmp = Console.ReadLine();
            if (Regex.IsMatch(tmp, @"^\d+$"))
                lastChose = Int32.Parse(tmp);
            else
                lastChose = 0;

            //ClearScreen
            Console.Clear();

            switch (lastChose)
            {
                case 1:
                    //New Game
                    GameLoop loop = new GameLoop();
                    break;
                case 9:
                    //exit program
                    return;
                default:
                    //accept other choices
                    Console.WriteLine("Please choose correct option...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}