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
            Console.WriteLine("test");
            hand.ForEach(x => Console.WriteLine(x.getSuit()));
            List<Card> suits = hand.FindAll(x => x.getSuit().Equals(userInput));
            suits.ForEach(x => Console.WriteLine(x.getSuit()));

            return suits.Count;
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
