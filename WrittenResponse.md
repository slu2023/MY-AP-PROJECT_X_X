# Word Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to play a word-guessing game for entertainment.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that my program can generates a random word for the player and display the info of the word to the user at each time base on user input. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard, which they enter their input as a word.
Then it displays information about the correct based on the input word the user typed (output).

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp

List<string> words = new List<string>();

    words.Add("ice-cream");
    words.Add("sandwich");
    words.Add("burger");

```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp

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

```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in "words".

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the words that my program is about to ask the user to guess.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity by allowing me to easily add words without make a bunch of changes to my code.  
Without a list, I would have to create several new word variables each time I want to add a code. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp

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

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp

Info(guess, correctWord);

```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Check if the user guessed the correct word.  If not, this method will display corresponding info to the user. This method is used every time the user makes a guess.


### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Compare the user guess with the correct word.
2. Loop through for each info display in the guess.
3. Display the info.
4. Reset the color back.
5. Return.

// 1. If the guess is in the correct position, select the color green.
// 2. If the guess is in the correct word but not correct position, select yellow.
// 3. If the guess is not in the correct word, select grey.
// 4. Display the guess
// 5. Reset the color back to white before returning
   
## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

Choice(null);

Second call:

Choice(char letter, int pos, string correct);

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This tests that the method fails when the input is null by throwing an exception.
This will test if the input is mull thus executing the body of the if statement.

Condition(s) tested by the second call:

This tests that the method runs when then input is not null.

### 3d iii.

Result of the first call:

This result is an exception is thrown.

Result of the second call:

The result is some color-information being displayed. 