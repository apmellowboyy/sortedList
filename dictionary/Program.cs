using System;
using System.ComponentModel;
using System.Collections;
namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<string, string> gamesList = new SortedList<string, string>(); 
            gamesList.Add("Silent Hill", "Ps1");
            gamesList.Add("THPS4", "PS2");
            gamesList.Add("Jak 2", "PS2");
            gamesList.Add("RE: Nemesis", "PS1");
            gamesList.Add("MX vs. ATV Unleashed", "PS2");

            Console.WriteLine("Sorted games list include:");
            foreach (KeyValuePair<string, string> gl in gamesList)
            {
                Console.WriteLine($"Key = {gl.Key}  Value={gl.Value}");
            }
            Console.WriteLine("Which game would you like to choose?");
            string game = Console.ReadLine();
            Console.WriteLine("What Console is this game on?");
            string console = Console.ReadLine();
            if (gamesList.ContainsValue(game))
                Console.WriteLine($"{game} is one of the games in your list");
            else
            {

                if (gamesList.ContainsKey(console))
                {
                    Console.WriteLine($"only one game on my {console} dawg...");
                    gamesList.Remove(console);
                    gamesList.Add(console, game);
                    Console.WriteLine($" {console} has been removed and {game} has been added");
                }
                else
                {
                    gamesList.Add(console, game);
                    Console.WriteLine($"{game} and {console} was added to your list");
                }
            }
            Console.WriteLine("Games and Consoles include:");
            foreach (KeyValuePair<string, string> gl in gamesList)
            {
                Console.WriteLine($"Key = {gl.Key}  Value={gl.Value}");
            }
            gamesList.RemoveAt(3);
        }
    }
}

