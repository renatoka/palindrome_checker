using System;
using System.Linq;

namespace palindrome_checker
{
    class Program
    {
        static void Main(string[] args)
        {


            bool stop = false;
            do
            {
                string word;
                string text;
                //Asks for user string input
                Console.Write($"Please input a word you wish to check: ");

                //Lowercasing a word so that capital letters at the beggining of the word don't make problems.
                word = Console.ReadLine().ToLower();
                /*
                 * Converts user's input into char array to
                 * reverse the word's order.
                */

                char[] reverse = word.ToArray();
                Array.Reverse(reverse);

                /*
                 * Without this line we wouldn't be able to compare "==" on if statement
                 * because we can't compare char to a string.
                */

                text = new string(reverse).ToLower();

                if (word == text)
                {
                    Console.Clear();
                    Console.WriteLine("It's a palindrome.\n");

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("It's not a palindrome.\n");

                }
            } while (stop != true);

        }
    }
}
