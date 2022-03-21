using System;
using System.Collections.Generic;
using System.IO;

namespace MY_AP_PROJECT_X_X
{
    class TestUserInput
    {
        public static string RunTest()
        {
            string guess;
            string word = "banana";
            int length = word.Length;
            Console.WriteLine("Your guess:  ");
            guess = Console.ReadLine();
            if (guess.Length != word.Length)
            {
                Console.Error.WriteLine("Your guess has to contains {word.Length} letters!");
                return guess;
            }

            return guess;
        }
    }
}