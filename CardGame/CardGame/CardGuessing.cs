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

            // set up human player
            HumanPlayer.numOfGuesses = 5;
            HumanPlayer.numOfQuestions = 3;

            // set up computer player
            ComputerPlayer.hand.AddRange(game.deal(13));
            ComputerPlayer.handSave = ComputerPlayer.hand;    // copy hand values for later use

            userInterface();    // call UI
        }

        public static void userInterface()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                // if number of guesses == 0 end the program

                Console.WriteLine();
                Console.WriteLine("Welcome to the Card Guessing Game----!");
                Console.WriteLine("Num of Guesses Remaining: " + HumanPlayer.numOfGuesses);
                Console.WriteLine("Num of Questions Remaining: " + HumanPlayer.numOfQuestions);
                Console.WriteLine();
                Console.WriteLine("\t1. Query\n" + "\t2. Guess\n" + "\t3. Quit\n");

                switch(userInput()) // handle user input
                {
                    case "1":
                        if (HumanPlayer.numOfQuestions > 0)
                            UserQuestions();
                        else
                        {
                            Console.WriteLine("---");
                            Console.WriteLine("You're out of Questions!!");
                        }
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

            // once the program is has ended, display total # of correct guesses
            // display the computers hand
            // thank you message
        }

        public static void UserQuestions()
        {
            bool didQuit = false;

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
                    didQuit = InputHandler1(uInput);
                    break;

                case "2":
                    Console.WriteLine("---");
                    Console.WriteLine("How many cards of ___ value are there?");
                    Console.WriteLine("Please input a value between 2-14 (NOTE: 11 = J, 12 = K, 13 = Q, 14 = A)");
                    Console.WriteLine("To go to main menu input 15");
                    Console.WriteLine();
                    uInput = int.Parse(userInput()) - 1;    // convert input to int
                    didQuit = InputHandler2(uInput);
                    break;

                case "3":
                    Console.WriteLine("---");
                    Console.WriteLine("What is the sum of values for ___ suit?");
                    Console.WriteLine("Please select a suit:");
                    Console.WriteLine("\t1. Clubs\n"
                                    + "\t2. Spades\n"
                                    + "\t3. Hearts\n"
                                    + "\t4. Diamonds\n"
                                    + "\t5. Back to Main Menu\n");
                    uInput = int.Parse(userInput()) - 1;    // convert input to int
                    didQuit = InputHandler3(uInput);
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input!");
                    userInput();
                    break;
            }

            if (!didQuit)
                HumanPlayer.AskQuestion(); // -1
        }

        public static void UserGuess()
        {
            // guess the suit
            Console.WriteLine("---");
            Console.WriteLine("Guess a Card! (Suit + Card Value)");
            Console.WriteLine("Please select a suit:");
            Console.WriteLine("\t1. Clubs\n"
                            + "\t2. Spades\n"
                            + "\t3. Hearts\n"
                            + "\t4. Diamonds\n"
                            + "\t5. Back to Main Menu\n");
            int uInputSuit = int.Parse(userInput()) - 1;    // convert input to int
            // input validation
            if (uInputSuit == 4)
            {
                return; //so guesses aren't taken away
                             // nothing, go back to beggining
            }
            else if (uInputSuit > 4 || uInputSuit < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input!");
                return;
            }

            // guess the value
            Console.WriteLine("How many cards of ___ value are there?");
            Console.WriteLine("Please input a value between 2-14 (NOTE: 11 = J, 12 = K, 13 = Q, 14 = A)");
            Console.WriteLine("To go to main menu input 15");
            Console.WriteLine();
            int uInputValue = int.Parse(userInput()) - 1;    // convert input to int
            // input valiation
            if (uInputValue == 14)
            {
                return; //so guesses aren't taken away
                             // nothing, go back to beggining
            }
            else if (uInputValue > 14 || uInputValue < 1)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input!");
                return;
            }

            // handle the guess
            // say if right or wrong
            // if right, remove card from hand
            // subtract one from # of guesses
        }

        public static bool InputHandler1(int uInput)
        {
            if (uInput == 4)
            {
                return true; //so guesses aren't taken away
                                // nothing, go back to beggining
            }
            else if (uInput > 4 || uInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input!");
                return true;
            }
            else
            {
                int num = ComputerPlayer.NumOfCardsForASuit(uInput);
                Console.WriteLine("");
                Console.WriteLine("The Computer's hand contains: " + num + " " + (Suits)uInput);
            }

            return false;
        }

        public static bool InputHandler2(int uInput)
        {
            if (uInput == 14)
            {
                return true; //so guesses aren't taken away
                             // nothing, go back to beggining
            }
            else if (uInput > 14 || uInput < 1)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input!");
                return true;
            }
            else
            {
                int num = ComputerPlayer.NumOfValueCards(uInput);
                Console.WriteLine("");
                Console.WriteLine("The Computer's hand contains: " + num + " " + (uInput + 1) + "'s");
            }

            return false;
        }

        public static bool InputHandler3(int uInput)
        {
            if (uInput == 4)
            {
                return true; //so guesses aren't taken away
                             // nothing, go back to beggining
            }
            else if (uInput > 4 || uInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input!");
                return true;
            }
            else
            {
                int num = ComputerPlayer.TotalValueForSuit(uInput);
                Console.WriteLine("");
                Console.WriteLine("The total value of "+ (Suits)uInput + "'s is: " + num);
            }

            return false;
        }

        // return the user input
        public static string userInput()
        {
            Console.Write("\t * Your Input: ");
            return Console.ReadLine();
        }

    }
}