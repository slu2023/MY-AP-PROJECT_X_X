using System;
using System.Collections.Generic;
using System.IO;

namespace MY_AP_PROJECT_X_X
{
    class TestUserInput
    {
        public static string RunTest()
        {
            List<string> words = new List<string>();

            words.Add("ice-cream");
            words.Add("sandwich");
            words.Add("burger");
            words.Add("running");
            words.Add("basketball");

            Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string word = words[index];
            int length = word.Length;
            string randomWord = words[index];
            string guess;
            Console.WriteLine("Your random word is generated!");
            Console.WriteLine($"It contains {randomWord.Length} letters");

            Console.WriteLine("Your guess:  ");
            guess = Console.ReadLine();
            if (guess.Length != word.Length)
            {
                Console.Error.WriteLine($"Your guess has to contains {randomWord.Length} letters!");
                return guess;
            }

            return guess;
        }
    }
}