using System;

namespace MY_AP_PROJECT_X_X
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }
        }

        public static void TestAll()
        {
            string testTheWord = TestTheWord.RunTest();
            Console.WriteLine($"Test TheWord(words);{testTheWord}");
            string testUserInput = TestUserInput.RunTest();
            Console.WriteLine($"Test UserInput(words);{testUserInput}");
            bool testInfo = TestInfo.RunTest();
            Console.WriteLine($"Test Info(words);{testInfo}");
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
            return null;
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
        public static string UserInput(string prompt)
        {
            return null;
        }

        public static string UserInput()
        {

            // 1. Count the number of letters in the secret word.
            // 2. Store the number of letters in the secret word in Word.Length.
            // 3. Prompt the user to make a guess
            // 4. Read input from the keyboard and store the results in a variable named guess.
            // 5. If guess is the correct length, return the guess.
            // 6. If guess is the incorrect length, display the message that guess must contains x letters.
            return null;
        }

        /// <summary>
        /// Check if the user guessed the word
        /// If yes, display yes
        /// If not, display infomation about the word to the player by colors
        /// Loop back to asking the player to guess, until they wins
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>
        public static void Info(string guess, string correct)
        {

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
