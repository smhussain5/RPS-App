namespace RPSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 = ROCK; R > S
            // 2 = PAPER; P > R
            // 3 = SCISSORS; S > P

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  _____               _         _____                             _____        _                              _ \r\n |  __ \\             | |       |  __ \\                           / ____|      (_)                            | |\r\n | |__) | ___    ___ | | __    | |__) |__ _  _ __    ___  _ __  | (___    ___  _  ___  ___   ___   _ __  ___ | |\r\n |  _  / / _ \\  / __|| |/ /    |  ___// _` || '_ \\  / _ \\| '__|  \\___ \\  / __|| |/ __|/ __| / _ \\ | '__|/ __|| |\r\n | | \\ \\| (_) || (__ |   <  _  | |   | (_| || |_) ||  __/| | _   ____) || (__ | |\\__ \\\\__ \\| (_) || |   \\__ \\|_|\r\n |_|  \\_\\\\___/  \\___||_|\\_\\( ) |_|    \\__,_|| .__/  \\___||_|( ) |_____/  \\___||_||___/|___/ \\___/ |_|   |___/(_)\r\n                           |/               | |             |/                                                  \r\n                                            |_|                                                                 ");

            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("\nEnter '1' for ROCK...");
                Console.WriteLine("Enter '2' for PAPER...");
                Console.WriteLine("Enter '3' for SCISSORS...");

                Console.Write("\nEnter your move: ");

                Random random = new Random();
                int cpuMove = random.Next(1, 4);
                int userMove = Convert.ToInt32(Console.ReadLine());

                Dictionary<int, string> rps = new Dictionary<int, string>
                {
                    {1, "ROCK"},
                    {2, "PAPER"},
                    {3, "SCISSORS"}
                };

                Console.WriteLine($"\nYOU: {rps[userMove]}");
                Console.WriteLine($"CPU: {rps[cpuMove]}");

                if (userMove == cpuMove)
                {
                    Console.WriteLine("\nIt's a TIE!");
                }
                else if ((userMove == 2 && cpuMove == 1) || (userMove == 3 && cpuMove == 2) || (userMove == 1 && cpuMove == 3))
                {
                    Console.WriteLine($"\n{rps[userMove]} BEATS {rps[cpuMove]}");
                    Console.WriteLine("\nYou WON!");
                }
                else
                {
                    Console.WriteLine($"\n{rps[cpuMove]} BEATS {rps[userMove]}");
                    Console.WriteLine("\nYou LOST!");
                }

                Console.WriteLine("\nPlay again? (Y/N)");
                Console.Write("\nEnter Y or N: ");
                string userReplay = Console.ReadLine() ?? "N";
                if (userReplay.ToUpper() == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing! See you again next time!");
                }

            }
        }
    }
}
