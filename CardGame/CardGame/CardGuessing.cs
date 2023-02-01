namespace CardGame
{
    internal class CardGuessing
    {
        static void Main(string[] args)
        {
            // run main program setup
            GameManager game = new GameManager();
            ComputerPlayer cpuPlayer = new ComputerPlayer();
            game.createDeck();

            cpuPlayer.hand.AddRange(game.deal(13));
            cpuPlayer.hand = cpuPlayer.handSave;    // copy hand values for later use

            userInterface();    // call UI
        }

        public static void userInterface()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the Card Guessing Game----!");
                Console.WriteLine();
                Console.WriteLine("\t1. Query\n" + "\t2. Guess\n" + "\t3.Quit\n");
                Console.Write("\tYour Input: ");
                var userInput = Console.ReadLine();

                switch(userInput) // handle user input
                {
                    case "1":
                        break;
                   
                    case "2":
                        break;
                    
                    case "3":
                        keepGoing = false;
                        break;
                }
            }
        }
    }
}