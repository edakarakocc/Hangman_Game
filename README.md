# Hangman Game in C#

## Description

This is a simple console-based Hangman game written in C#. The game selects a random word from a predefined list, and the player has to guess the word one letter at a time. The player has a limited number of incorrect guesses before the game ends.

## Features
- Random word selection from a predefined list.
- User input validation to ensure only single letters are accepted.
- Displays the progress of guessed letters and incorrect guesses.
- Hangman figure visualization as incorrect guesses increase.
- Ends game after six incorrect guesses or when the word is fully guessed.

## How to Play
1. Run the program.
2. The game will display underscores representing the hidden word.
3. Enter a letter to guess.
4. If the letter is correct, it will be revealed in the word.
5. If the letter is incorrect, it will be added to the incorrect guesses list, and the hangman figure will update.
6. The game continues until the player either guesses the word or reaches six incorrect guesses.
