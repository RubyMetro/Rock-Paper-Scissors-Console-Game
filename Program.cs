using System;

namespace Rock_Paper_Scissors_console_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heya! Welcome to Rock Paper Scissors, if you havent played before, here's how it works\nYou will be playing against the computer, you have three options to choose from, Rock, Paper, or Scissors.\n-Rock beats Scissors\n-Scissors beats Paper\n-Paper beats Rock\nYou can type the following to select:\nr = Rock\np = Paper\ns = Scissors\n\nAre you ready? Press any key to begin!");
            Console.ReadKey();
            Console.WriteLine("How many games would you like to play?");
            var games = Console.ReadLine();
            int numberOfGames;
            int userWins = 0;
            int computerWins = 0;
            while (!int.TryParse(games, out numberOfGames))
            {
                Console.WriteLine("Whoops, thats not a number. can you Type that again?");
                games = Console.ReadLine();
            }
            while (numberOfGames > 0)
            {
                Console.Clear();
                Console.WriteLine("\nPlease type r, p, or s to choose your object.");
                string user;
                user = Console.ReadLine();
                user = user.ToLower();
                while (user != "r" && user != "p" && user != "s")
                {
                    Console.WriteLine("Lets try that again, please type r, p, or s to chose your object.");
                    user = Console.ReadLine();
                    user = user.ToLower();
                }
                if (user == "r") Console.WriteLine("You chose Rock!");
                else if (user == "p") Console.WriteLine("You chose Paper!");
                else Console.WriteLine("You chose Scissors!");
                string[] options = new[] { "r", "p", "s" };
                var random = new Random();
                int optionsIndex = random.Next(0, options.Length);
                string computer;
                computer = options[optionsIndex];
                if (computer == "r") Console.WriteLine("Computer chose Rock!");
                else if (computer == "p") Console.WriteLine("Computer chose Paper!");
                else Console.WriteLine("Computer chose Scissors!");
                if (user == computer) Console.WriteLine("Tie!");
                else if (user == "r" && computer == "s")
                {
                    userWins++;
                    Console.WriteLine($"User scored! User: {userWins} | Computer: {computerWins}");
                }
                else if (user == "p" && computer == "s")
                {
                    computerWins++;
                    Console.WriteLine($"Computer scored! User: {userWins} | Computer: {computerWins}");
                }
                else if (user == "r" && computer == "p")
                {
                    computerWins++;
                    Console.WriteLine($"Computer scored! User: {userWins} | Computer: {computerWins}");
                }
                else if (user == "s" && computer == "p")
                {
                    userWins++;
                    Console.WriteLine($"User scored! User: {userWins} | Computer: {computerWins}");
                }
                else if (user == "p" && computer == "r")
                {
                    userWins++;
                    Console.WriteLine($"User scored! User: {userWins} | Computer: {computerWins}");
                }
                else if (user == "s" && computer == "r")
                {
                    computerWins++;
                    Console.WriteLine($"Computer scored! User: {userWins} | Computer: {computerWins}");
                }
                numberOfGames--;
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"Thats the game! Final scores: User: {userWins} | Computer: {computerWins}");
            if (computerWins > userWins) Console.WriteLine("The computer wins!");
            else if (userWins > computerWins) Console.WriteLine("The user wins!");
            else Console.WriteLine("It was a tie!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
