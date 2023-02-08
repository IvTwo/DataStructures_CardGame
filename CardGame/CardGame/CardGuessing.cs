/**************************************
 * Name: Jasmine C.
 * Date: 2/1/2023
***************************************/
namespace CardGame
{
    internal class CardGuessing
    {
        public enum Suits
        {
            Clubs,
            Spades,
            Hearts,
            Diamonds
        }

        static void Main(string[] args)
        {
            // run main program setup
            GameManager game = new GameManager();
            game.createDeck();

            ComputerPlayer.hand.AddRange(game.deal(13));
            ComputerPlayer.handSave = ComputerPlayer.hand;    // copy hand values for later use

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
                Console.WriteLine("\t1. Query\n" + "\t2. Guess\n" + "\t3. Quit\n");

                switch(userInput()) // handle user input
                {
                    case "1":
                        userQuestions();
                        break;
                   
                    case "2":
                        break;
                    
                    case "3":
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }

        public static void userQuestions()
        {
            Console.WriteLine("---");
            Console.WriteLine("Ask the Computer:  ");
            Console.WriteLine("\t1. How many cards of a specific suit?\n"
                            + "\t2. How many cards of a specific value?\n"
                            + "\t3. What is the sum of values for a specific suit?\n"
                            + "\t4. Back to Main Menu\n");
            
            switch (userInput())
            { 
                case "1":   // can break here bc invalid input
                    Console.WriteLine("---");
                    Console.WriteLine("How many cards of ___ suit are there?");
                    Console.WriteLine("Please select a suit:");
                    Console.WriteLine("\t1. Clubs\n"
                                    + "\t2. Spades\n"
                                    + "\t3. Hearts\n"
                                    + "\t4. Diamonds\n"
                                    + "\t5. Back to Main Menu\n");
                    int uInput = int.Parse(userInput()) - 1;    // convert input to int

                    if (uInput == 4)
                    {
                        // nothing, go back to beggining
                    }
                    else if (uInput > 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input!");
                        userInput();
                    }
                    else
                    {
                        int num = ComputerPlayer.NumOfCardsForASuit(uInput);
                        Console.WriteLine("");
                        Console.WriteLine("The Computer's hand contains: " + num + " " + (Suits)uInput);
                    }
                    break;

                case "2":
                    Console.WriteLine("---");
                    Console.WriteLine("How many cards of ___ value are there?");
                    Console.WriteLine("Please input a value:\n" 
                                    + "(NOTE: 11 = J, 12 = K, 13 = Q, 14 = A");
                    break;

                case "3":
                    Console.WriteLine("---");
                    Console.WriteLine("What is the sum of values for ___ suit?");
                    Console.WriteLine("Please select a suit:");
                    Console.WriteLine("\t1. Clubs\n"
                                    + "\t2. Spades\n"
                                    + "\t3. Hearts\n"
                                    + "\t4. Diamonds\n"
                                    + "\t5. Back\n");
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input!");
                    userInput();
                    break;
            }
        }

        // return the user input
        public static string userInput()
        {
            Console.Write("\t * Your Input: ");
            return Console.ReadLine();
        }

    }
}