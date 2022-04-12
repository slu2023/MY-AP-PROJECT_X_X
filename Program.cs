using System;
using System.Collections.Generic;

namespace MY_AP_PROJECT_X_X
{
    class Program
    {

        private static object guess;
        private static object correctWord;

        static void Main(string[] args)
        {
            // Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
            string correctWord;
            string guess;
            correctWord = TheWord();

            do
            {
                guess = UserInput(correctWord);
                Info(guess, correctWord);
                Console.WriteLine();
            } while (guess != correctWord);
            // return UserInput(correctWord);
        }



        public static void TestAll()
        {
            // string testTheWord = TestTheWord.RunTest();
            // Console.WriteLine($"Test TheWord(words);{testTheWord}");
            // string testUserInput = TestUserInput.RunTest();
            // Console.WriteLine($"Test UserInput(words);{testUserInput}");
            // bool testInfo = TestInfo.RunTest();
            // Console.WriteLine($"Test Info(words);{testInfo}");
        }


        /// <summary>
        /// Generates a word for the player to guess
        /// </summary>
        /// <returns>the random word that was generated</returns>

        public static string TheWord()
        {

            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)

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
            Console.WriteLine("Your random word is generated!");
            Console.WriteLine($"It contains {randomWord.Length} letters");

            return randomWord;
        }

        /// <summary>
        /// Count the number of letters in the unknown word
        /// Display the length of words to the player
        /// Ask the user to make a guess
        /// Check if the user-input-word fits the requirement
        /// Storing the valid answers from the player
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>Valid User Input</returns>
        public static string UserInput(string word)
        
        {
            Console.Write("Your guess:  ");
            string guess;
            guess = Console.ReadLine();
            if (guess.Length != word.Length)
            {
                Console.Error.WriteLine($"Your guess has to contains {word.Length} letters!");
                return guess;
            }

            return guess;
        }


        /// <summary>
        /// Check if the user guessed the word
        /// If yes, display yes
        /// If not, display infomation about the word to the player by colors
        /// Loop back to asking the player to guess, until they wins
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>
        public static bool Info(string guess, string correct)
        {
            // string word = "basketball";
            int length = correct.Length;
            // Console.WriteLine("Your guess:  ");
            // guess = Console.ReadLine();
            if (guess == correct)
            {
                Console.Error.WriteLine($"The word is {correct}");
            }
            else
            {
                int pos = 0;

                foreach (char letter in guess)
                {
                    if (correct.Contains(letter) == true)
                    {
                        if (letter == correct[pos])
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

        public static void Info(char letter, int pos, string correct)
        {

            // 1. If the guess is in the correct position, select the color green.
            // 2. If the guess is in the correct word but not correct position, select yellow.
            // 3. If the guess is not in the correct word, select grey.
            // 4. Display the guess
            // 5. Reset the color back to white before returning

        }
    }
}
