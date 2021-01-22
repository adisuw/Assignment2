using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    /// <summary>
    /// The UserInputReader class reads user inputs and converts to number formats using some naive validation
    /// techniques like using .TryParse()
    /// </summary>
    public class UserInputReader
    {
        //this message is used in all validations
        private const string Message = "\tInvalid Input!\n\tPlease try again ... \n";

        /// <summary>
        /// while it gets a proper inputs the method keeps iterating
        /// and informs the user.
        /// </summary>
        /// <param name="userMessage"></param>
        /// <returns></returns>
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

        /// <summary>
        /// It parses the string input into integer value
        /// it first checks to parse, if it fails,
        /// it will continue the loop until it gets the proper input.
        /// </summary>
        /// <param name="userMessage"></param>
        /// <returns>the parsed value is returned</returns>
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

        /// <summary>
        /// a private method used to check if it is possible to parse an integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsIntParseable(string input)
        {
            return int.TryParse(input, out _);
        }
        /// <summary>
        /// The same functionality with the previous function but to a double type.
        /// </summary>
        /// <param name="userMessage"></param>
        /// <returns></returns>
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
