using System;
using System.Collections.Generic;
using Players;

namespace GameLoops
{
    public class GameLoop
    {
        public int WinValue;
        public List<Player> Players;
        public int Turn;
        public bool IsGameFinished;

        public void PressAnyKeyNoErease()
        {
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
        }
        public void PressAnyKey()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
        }

        public void PressAnyKey(string s)
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to " + s + "...");
            Console.ReadKey();
            Console.Clear();
        }

        public void PressAnyKey(string preS, string s)
        {
            Console.WriteLine("");
            Console.WriteLine(preS + '\n' + '\n' + "Press any key to " + s + "...");
            Console.ReadKey();
            Console.Clear();
        }

        public GameLoop()
        {
            //initiate
            Console.Clear();
            Players = new List<Player>();
            Turn = 0;
            IsGameFinished = false;

            //Ask for how much points to get to win
            Console.Write("Please set winning points value: ");
            WinValue = Int32.Parse(Console.ReadLine());
            
            //add 2 players
            for (int i = 1; i <= 2; i++)
                Players.Add(new Player(i));

            //Play
            Console.Clear();
            while (!IsGameFinished)
            {
                //increment turn
                Turn++;

                //Communicate begin of turn
                PressAnyKey("Turn " + Turn + " begins.", "start");

                //Select gesture
                foreach(Player p in Players)
                {
                    //nullify Last Move
                    p.LastMove = "";

                    PressAnyKey("Turn of " + p.Name, " starts");


                    //Player Choice until player choose proper string
                    while (p.LastMove == "")
                    {
                        Console.WriteLine(p.Name + " select one of gestures and press Enter:");
                        Console.WriteLine("[1] Rock");
                        Console.WriteLine("[2] Paper");
                        Console.WriteLine("[3] Scissors");
                        p.LastMove = Console.ReadLine();

                        switch (p.LastMove)
                        {
                            case "1":
                                p.LastMove = "Rock";
                                break;
                            case "2":
                                p.LastMove = "Paper";
                                break;
                            case "3":
                                p.LastMove = "Scissors";
                                break;
                            default:
                                p.LastMove = "";
                                break;
                        }

                        Console.Clear();
                    }
                }

                //Pause until both player see
                PressAnyKey("see who won");

                //Check who won turn
                string tmpCommunicate = Players[0].Name + " played with " + Players[0].LastMove;

                if (Players[0].LastMove == Players[1].LastMove)
                    tmpCommunicate += " same as " + Players[1].Name + '\n' + "It means draw. No one gets point.";
                else
                {
                    switch (Players[0].LastMove)
                    {
                        case "Rock":
                            ///TODO - wrap those ifs with function
                            if (Players[1].LastMove == "Paper") //Lose Case
                            {
                                tmpCommunicate += " when " + Players[1].Name + " played with " + Players[1].LastMove + '\n'
                                    + "It means that " + Players[1].Name + " won and gets one point.";
                                Players[1].Points++;
                            }
                            else if (Players[1].LastMove == "Scissors") //Won Case
                            {
                                tmpCommunicate += " when " + Players[1].Name + " played with " + Players[1].LastMove + '\n'
                                    + "It means that " + Players[0].Name + " won and gets one point.";
                                Players[0].Points++;
                            }
                            break;
                        case "Paper":
                            if (Players[1].LastMove == "Scissors")
                            {
                                tmpCommunicate += " when " + Players[1].Name + " played with " + Players[1].LastMove + '\n'
                                    + "It means that " + Players[1].Name + " won and gets one point.";
                                Players[1].Points++;
                            }
                            else if (Players[1].LastMove == "Rock")
                            {
                                tmpCommunicate += " when " + Players[1].Name + " played with " + Players[1].LastMove + '\n'
                                    + "It means that " + Players[0].Name + " won and gets one point.";
                                Players[0].Points++;
                            }
                            break;
                        case "Scissors":
                            if (Players[1].LastMove == "Rock")
                            {
                                tmpCommunicate += " when " + Players[1].Name + " played with " + Players[1].LastMove + '\n'
                                    + "It means that " + Players[1].Name + " won and gets one point.";
                                Players[1].Points++;
                            }
                            else if (Players[1].LastMove == "Paper")
                            {
                                tmpCommunicate += " when " + Players[1].Name + " played with " + Players[1].LastMove + '\n'
                                    + "It means that " + Players[0].Name + " won and gets one point.";
                                Players[0].Points++;
                            }
                            break;
                    }
                }

                //show who won turn
                Console.WriteLine(tmpCommunicate);
                PressAnyKey();

                //show points
                Console.WriteLine("Points after turn " + Turn +":");
                foreach (Player p in Players)
                {
                    Console.WriteLine(p.Name + ": " + p.Points);
                }
                PressAnyKeyNoErease();

                //check for winners
                foreach (Player p in Players)
                {
                    if (p.Points >= WinValue)
                    {
                        IsGameFinished = true;

                        //show who won the game
                        Console.Clear();
                        Console.WriteLine(p.Name + " won the game. Congratulations!");
                        PressAnyKey();
                    }
                }
            }
        }
    }
}