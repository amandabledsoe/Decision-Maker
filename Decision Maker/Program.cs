using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Decision Maker Application!");
            Console.WriteLine("Who do we have the pleasure of working with today? (Please enter your name)");
            string userName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Welcome to our application, {userName}!");

            bool makingDecisions = true;
            while (makingDecisions)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter a number between 1 and 100.");
                string userNumber = Console.ReadLine().Trim();
                int num;
                bool isANum = int.TryParse(userNumber, out num);
                if (!isANum)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Sorry {userName}, but I didn't detect a number in your response. Please try again.");
                    makingDecisions = true;
                }
                else if (num <= 0 || num > 100)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Sorry {userName}, but we're not accepting numbers outside the range of 1-100 at this time. Please try again.");
                    makingDecisions = true;
                }
                else if (isANum && num % 2 != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Thanks, {userName}! This number is ODD.");
                    makingDecisions = false;
                }
                else if (isANum && num % 2 == 0 && num < 25)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Thanks, {userName}! This number is EVEN and less than 25.");
                    makingDecisions = false;
                }
                else if (isANum && num % 2 == 0 && num >= 26 && num <= 100)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Thanks, {userName}! This number is EVEN.");
                    makingDecisions = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Some error occured. Please try again.");
                    makingDecisions = true;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Thanks very much for using our application.");
            Console.WriteLine("Have a great day!");
            Console.WriteLine("");
            Environment.Exit(0);
        }
    }
}
