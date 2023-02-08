using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
