using System;

class Program
{
    static void Main()
    {
        // Declare an array to hold the options
        string[] choices = { "Rock", "Paper", "Scissors" };

        // Create an instance of Random class for generating random choices for the computer
        Random rand = new Random();

        // Boolean flag to control the game loop
        bool playAgain = true;

        // Game loop
        while (playAgain)
        {
            // Computer's choice (randomly generated)
            int computerChoice = rand.Next(choices.Length);

            // User's choice
            Console.WriteLine("Choose [1] Rock, [2] Paper, [3] Scissors:");
            string userInput = Console.ReadLine();
            int userChoice;

            // Validate user input
            if (int.TryParse(userInput, out userChoice) && userChoice >= 1 && userChoice <= 3)
            {
                userChoice--; // Adjusting for 0-based index
                Console.WriteLine($"\nYou chose: {choices[userChoice]}");
                Console.WriteLine($"Computer chose: {choices[computerChoice]}\n");

                // Determine winner
                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((userChoice == 0 && computerChoice == 2) ||
                         (userChoice == 1 && computerChoice == 0) ||
                         (userChoice == 2 && computerChoice == 1))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                continue;
            }

            // Ask if the player wants to play again
            Console.WriteLine("\nDo you want to play again? (y/n):");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "y";
        }

        Console.WriteLine("Thanks for playing!");
    }
}
