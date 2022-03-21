using System;
using System.Collections.Generic;
using System.IO;

namespace MY_AP_PROJECT_X_X
{
    class TestTheWord
    {
        private static int wordsCount;

        public static string RunTest()
        {

            // Random generator; // A random word generator
            // string randomNumber; // The word the player is trying to guess
            // List<string> word; // A list of all of the words the players guesses would come from
            // generator = new Random();
            // words = new List<string>(); //0, words.Count);
            // return false;

            List<string> words = new List<string>();

            words.Add("ice-cream");
            words.Add("sandwich");
            words.Add("burger");
            words.Add("running");
            words.Add("basketball");

            Random generator = new Random();
            int index = generator.Next(0, wordsCount);

            string word = "banana";
            int length = word.Length;
            string randomWord = words[index];
            Console.WriteLine("Your random word is generated!");
            Console.WriteLine("It contains {Length} letters");

            return null;

        }
    }
}