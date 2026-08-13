# Hangman Game

A C# console-based Hangman game where the player tries to guess a randomly selected word by entering individual letters.

## Overview

This project is a simple console game developed using C#.

At the beginning of the game, a random word is selected from a predefined word list. The player attempts to discover the hidden word by guessing letters one at a time.

Correctly guessed letters are revealed in their corresponding positions, while incorrect guesses increase the number of wrong attempts and update the Hangman visualization.

## Features

- Random word selection from a predefined word list
- User input validation
- Single-letter guesses
- Display of correctly guessed letters
- Tracking of incorrect guesses
- Dynamic Hangman visualization based on incorrect guesses
- Game completion when the word is correctly guessed
- Game over after 6 incorrect guesses

## Game Flow

```text
Start Game
    │
    ▼
Select Random Word
    │
    ▼
Display Hidden Word
    │
    ▼
Get Letter Guess
    │
    ├── Correct Guess ──► Reveal Letter
    │
    └── Incorrect Guess ──► Increase Wrong Guess Count
                                  │
                                  ▼
                         Update Hangman Display
                                  │
                                  ▼
                            Is Game Over?
                              │       │
                             No      Yes
                              │       │
                              └───┐   ▼
                                  │ End Game
                                  ▼
                              Next Guess
```

## How to Play

1. Start the application.
2. The game randomly selects a word from the predefined word list.
3. The letters of the hidden word are displayed as underscores.
4. Enter a letter as your guess.
5. If the letter exists in the word, its corresponding position is revealed.
6. If the letter does not exist in the word, it is recorded as an incorrect guess and the Hangman visualization is updated.
7. Guess all the letters correctly to win the game.
8. The game ends after 6 incorrect guesses.

## Technologies

- C#
- .NET
- Console Application

## Project Purpose

The main purpose of this project is to practice fundamental C# programming concepts by developing a simple interactive game.

The project provides hands-on practice with:

- User input
- Conditional statements
- Loops
- Arrays and collections
- Random value generation
- Input validation
- Program flow control

## Project Status

This project is an educational console application developed to practice fundamental C# programming concepts.

The game provides a basic implementation of the classic Hangman gameplay mechanics.

## Running the Project

Clone the repository and open the project using a compatible C#/.NET development environment.

If the project is configured as a .NET application, it can be run from the command line using:

```bash
dotnet run
```

> Make sure that the appropriate .NET SDK is installed on your system before running the project.
