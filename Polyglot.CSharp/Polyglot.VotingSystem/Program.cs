namespace Polyglot.VotingSystem
{
    internal class Program
    {
        static void Main()
        {
            // List to store candidates and their votes
            List<string> candidates = new List<string> { "Alice", "Bob", "Charlie" };
            int[] votes = new int[candidates.Count];

            // Variable to control the voting process
            bool voting = true;

            Console.WriteLine("Welcome to the Basic Voting System!");
            Console.WriteLine("Here are the candidates:");

            // Display the candidates
            for (int i = 0; i < candidates.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {candidates[i]}");
            }

            // Voting loop
            while (voting)
            {
                Console.WriteLine("\nEnter the number corresponding to the candidate you want to vote for (1, 2, or 3):");
                string input = Console.ReadLine();
                int candidateIndex;

                // Validate user input
                if (int.TryParse(input, out candidateIndex) && candidateIndex >= 1 && candidateIndex <= candidates.Count)
                {
                    votes[candidateIndex - 1]++;  // Increment the vote count for the chosen candidate
                    Console.WriteLine($"You voted for {candidates[candidateIndex - 1]}.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    continue;
                }

                // Ask if the user wants to continue voting or stop
                Console.WriteLine("\nDo you want to continue voting? (y/n):");
                string response = Console.ReadLine().ToLower();
                if (response == "n")
                {
                    voting = false;
                }
            }

            // Display the final results
            Console.WriteLine("\nVoting Results:");
            for (int i = 0; i < candidates.Count; i++)
            {
                Console.WriteLine($"{candidates[i]}: {votes[i]} votes");
            }

            // Determine the winner
            int maxVotes = -1;
            string winner = "";
            bool tie = false;

            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] > maxVotes)
                {
                    maxVotes = votes[i];
                    winner = candidates[i];
                    tie = false;
                }
                else if (votes[i] == maxVotes)
                {
                    tie = true;
                }
            }

            // Announce the winner or a tie
            if (tie)
            {
                Console.WriteLine("\nThe election resulted in a tie.");
            }
            else
            {
                Console.WriteLine($"\nThe winner is: {winner} with {maxVotes} votes!");
            }

            Console.WriteLine("Thanks for participating in the voting system!");
            Console.ReadKey();
        }
    }
}
