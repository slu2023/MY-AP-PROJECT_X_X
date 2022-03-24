using System;
using System.Collections.Generic;
using System.IO;

namespace MY_AP_PROJECT_X_X
{
    class TestInfo
    {
        public static bool RunTest()
        {
            string guess;
            string word = "basketball";
            int length = word.Length;
            Console.WriteLine("Your guess:  ");
            guess = Console.ReadLine();
            if (guess == word)
            {
                Console.Error.WriteLine($"The word is {word}");
            }
            else
            {
                int pos = 0;

                foreach (char letter in guess)
                {
                    if (word.Contains(letter) == true)
                    {
                        if (letter == word[pos])
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    Console.Write(letter);
                    pos = pos + 1;

                }
            }
            Console.ForegroundColor = ConsoleColor.Black;
            return false;
        }
            
        }
}
