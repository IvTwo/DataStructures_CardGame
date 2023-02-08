using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Namespace;

namespace CardGame
{
    internal static class ComputerPlayer    // static bc we only want one
    {
        // holds the computers 13 cards
        public static List<Card> hand = new List<Card>();

        // saved list --> duplicate of list for end reveal
        public static List<Card> handSave = new List<Card>();

        public static int NumOfCardsForASuit(int userInput)
        {
            List<Card> suits = hand.FindAll(x => x.getSuit().Equals(userInput));

            return suits.Count;
        }

        public static int NumOfValueCards(int userInput) 
        {
            List<Card> values = hand.FindAll(x => x.getValue().Equals(userInput));

            return values.Count;
        }

        public static int TotalValueForSuit(int userInput)
        {
            int total = 0;
            List<Card> suits = hand.FindAll(x => x.getSuit().Equals(userInput));

            foreach (Card suit in suits) 
            { 
                total += suit.getValue();
            }

            return total;
        }

        public static void GuessCard(int suit, int value)
        {
            List<Card> suits = hand.FindAll(x => x.getSuit().Equals(suit));
            List<Card> values = suits.FindAll(x => x.getValue().Equals(value));

            // correct guess
            if(values.Count > 0) 
            {
                HumanPlayer.points++;
                Console.WriteLine("---");
                Console.WriteLine("You guesed a card correctly!");
                Console.WriteLine("Removing the " + (Value)value + " of " + (Suits)suit);

                // remove card
                hand.Remove(values[0]);
            }
            else    // wrong guess
            {
                Console.WriteLine("---");
                Console.WriteLine("You guessed Incorrectly :(");
                Console.WriteLine("There was no " + (Value)value + " of " + (Suits)suit);
            }
            HumanPlayer.numOfGuesses--;
        }

        //public int numOfCardsForAValue()
        //{
        //    return;
        //}

        //public int sumOfValuesForSuit()
        //{
        //    return;
        //}
    }
}
