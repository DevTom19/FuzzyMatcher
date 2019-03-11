using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyMatch;

namespace FuzzyMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //Console.SetWindowSize(500, 500);
                
                Console.WriteLine("Welcome to the Fuzzy Match testing application!");
                Console.WriteLine("You have two options:");
                //Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("1: Fuzzy search for a pattern within a string");
                Console.WriteLine("2: fuzzy search for a pattern within a string, gives score");
                //Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Key in the menu item now.");
                //Console.BackgroundColor = ConsoleColor.Black;
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out int keyPress);
                //Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the string to search:");
                var stringToSearch = Console.ReadLine();
                Console.WriteLine("Please enter the pattern:");
                var pattern = Console.ReadLine();
                //Console.BackgroundColor = ConsoleColor.White;
                switch (keyPress)
                {
                    case 1:
                        
                        var output = FuzzyMatcher.FuzzyMatch(stringToSearch, pattern);
                        Console.WriteLine(String.Format("You searched {0} for pattern {1}. Found? {2}", stringToSearch, pattern, output));
                        break;
                    case 2:
                        var found = FuzzyMatcher.FuzzyMatch(stringToSearch, pattern, out int score);
                        Console.WriteLine(String.Format("You searched {0} for pattern {1}. Found? {2} Score {3}", stringToSearch,pattern,found,score));
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Did not recognise the menu item choice.");
                        break;
                }
                //Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Press any key to continue, to exit key in 'e'");
                var key = Console.ReadKey();
                if (key.KeyChar == 'e') break;
                Console.Clear();
            }
        }
    }
}
