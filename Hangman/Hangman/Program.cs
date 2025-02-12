using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        // List of possible words for the game
        List<string> words = new List<string> { "computer", "keyboard", "desktop", "laptop", "software", "hardware", "code", "syntax", "debug" };
        int incorrect_guesses = 0; // Counter for incorrect guesses
         
        Random random = new Random(); // Create a random number generator
        int randomIndex = random.Next(words.Count); // Select a random word from the list
        string chosen_word = words[randomIndex];

        char[] word = chosen_word.ToCharArray(); // Convert the chosen word to a character array
        List<char> letters = new List<char>(new char[chosen_word.Length]); // List to store the letters of the word
        int word_length = word.Length;

        DisplayHangman(0); // Display initial hangman state

        for (int i = 0; i < word_length; i++) // Display underscores for each letter in the word
        {
            Console.Write("_ ");
        }
        Console.WriteLine();

        List<char> guessed_letters = new List<char>(); // List to store guessed letters

        while (true)
        {
            Console.Write("Guess a letter:"); // Prompt the user to enter a letter
            string guessed = Console.ReadLine().ToLower();

            if (guessed.Length == 1 && char.IsLetter(guessed[0])) // Ensure the input is a single valid letter
            {
                bool letterFound = false;

                for (int i = 0; i < word_length; i++) //Check if the guessed letter is in the word
                {
                    if (word[i] == guessed[0])
                    {
                        letters[i] = guessed[0];
                        letterFound = true;
                    }
                }

                if (letterFound)
                {
                    DisplayHangman(guessed_letters.Count);
                    Console.WriteLine("Good guess!" + "\n");
                }
                else
                {
                    // If the letter hasn't been guessed before, count it as an incorrect guess
                    if (!guessed_letters.Contains(guessed[0]))
                    {
                        incorrect_guesses++;
                        guessed_letters.Add(guessed[0]);
                    }

                    DisplayHangman(guessed_letters.Count);
                    Console.WriteLine("Incorrect guess." + "\n");
                }

                // Display the current state of the word
                for (int i = 0; i < word_length; i++)
                {
                    if (letters[i] == '\0') // If the letter is not guessed, display an underscore
                    {
                        Console.Write("_ ");
                    }
                    else // If the letter is guessed, display it
                    {
                        Console.Write(letters[i] + " ");
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("Incorrect letters: " + string.Join(", ", guessed_letters)); // Display wrong guesses

                if (incorrect_guesses >= 6) // If 6 or more incorrect guesses are made, the game ends
                {
                    Console.WriteLine("Game Over!");
                    break;
                }

                if (!letters.Contains('\0')) // If there are no underscores left, the word has been guessed correctly
                {
                    Console.WriteLine("Congratulations! You've guessed the word!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please guess a single letter.");
            }
        }

        Console.ReadKey(); // Wait for user input before exiting
    }

    // Function to draw the hangman figure based on the number of incorrect guesses
    private static void DisplayHangman(int guessed_letters)
    {
        Console.WriteLine("\n--"); // Draw the hanging post
        Console.WriteLine(" |");
        switch (guessed_letters)
        {
            case 1:
                Console.WriteLine(" 0 ");
                break;
            case 2:
                Console.WriteLine(" 0 ");
                Console.WriteLine(" | ");
                break;
            case 3:
                Console.WriteLine(" 0 ");
                Console.WriteLine(" | ");
                Console.WriteLine("/  ");
                break;
            case 4:
                Console.WriteLine(" 0 ");
                Console.WriteLine(" | ");
                Console.WriteLine("/ \\ ");
                break;
            case 5:
                Console.WriteLine(" 0 ");
                Console.WriteLine(" |\\ ");
                Console.WriteLine("/ \\ ");
                break;
            case 6:
                Console.WriteLine(" 0 ");
                Console.WriteLine("/|\\ ");
                Console.WriteLine("/ \\ ");
                break;

            default:
                Console.WriteLine("\n");
                break;
        }
        Console.WriteLine("\n");
    }
}