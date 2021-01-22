using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class UserInputReader
    {
        private const string Message = "\tInvalid Input!\n\tPlease try again ... \n";

        public static string ReadString(string userMessage)
        {
            Console.Write(userMessage);
            var userInput = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.Write(Message);
                    Console.Write(userMessage);
                    userInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return userInput;

        }

        public static int ReadInteger(string userMessage)
        {
            Console.Write(userMessage);
            var userInput = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(userInput) || !IsIntParseable(userInput))
                {
                    Console.Write(Message);
                    Console.Write(userMessage);
                    userInput = Console.ReadLine();
                }
                else
                {
                    int.TryParse(userInput, out var parsedInt);
                    return parsedInt;
                }
            }
        }

        private static bool IsIntParseable(string input)
        {
            return int.TryParse(input, out _);
        }

        public static double ReadDouble(string userMessage)
        {
            Console.Write(userMessage);
            var userInput = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(userInput) || !IsDoubleParseable(userInput))
                {
                    Console.Write(Message);
                    Console.Write(userMessage);
                    userInput = Console.ReadLine();
                }
                else
                {
                    double.TryParse(userInput, out var parsedDouble);
                    return parsedDouble;
                }
            }
        }

        private static bool IsDoubleParseable(string input)
        {
            return double.TryParse(input, out _);
        }


    }
}
