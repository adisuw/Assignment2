using System;
using System.Linq;
using System.Threading;
using Utils;



namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu() 
        {
            do
            {
                Console.WriteLine("\n\t************** Welcome to the main menu **************\n");
                Console.WriteLine("\tPress 0 to exit the program");
                Console.WriteLine("\tPress 1 to issue a cinema ticket");
                Console.WriteLine("\tPress 2 to display a word 10 times");
                Console.WriteLine("\tPress 3 to see the third word of your sentence");
                Console.WriteLine("\t******************************************************\n");
                switch (UserInputReader.ReadInteger("\tPlease enter your choice: "))
                {
                    case 0:
                        ShutDown(3);
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    case 1:
                        new PrintTickets().IssueTicket(GetUserType());
                        break;
                    case 2:
                        DisplayWords();
                        break;
                    case 3:
                        SplitString();
                        break;
                    default:
                        Console.WriteLine("\tInvalid choice please tray again.\n");
                        break;
                }
            } while (true);
        }

        private static void SplitString()
        {
            var input = UserInputReader.ReadString("\tEnter your sentence: ");
            var strArray = input.Split(" ");
            if (strArray.Length<3)
            {
                Console.WriteLine("\tThe number of words should be at least 3");
                return;
            }
            else
            {
                Console.WriteLine($"\tThe third word in your input is: {strArray[2]}");
            }

        }

        private static void DisplayWords()
        {
            var input = UserInputReader.ReadString("\tEnter your input: ");
            for (var i = 0; i < 10; i++) Console.Write($"{i+1}. {input} ");
            
        }

        private static bool GetUserType()
        {
            var numberOfTickets = UserInputReader.ReadInteger("\tHow many tickets do you want? ");
            do
            {
                if (numberOfTickets == 1)
                {
                    return true;
                }
                else if (numberOfTickets>1)
                {
                    return false;
                }
                else
                {
                
                    Console.WriteLine("\tThe number of tickets has to be greater than 0");
                    numberOfTickets = UserInputReader.ReadInteger("\tHow many tickets do you want? ");

                }

            } while (true);
        }

        private static void ShutDown(int seconds)
        {
            for (var i = seconds; i >= 1; i--)
            {
                Console.WriteLine($"\n\t Exiting your program in {i} seconds");
                Thread.Sleep(1000);
            }
        }
    }
}
