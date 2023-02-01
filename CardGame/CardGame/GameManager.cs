using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class GameManager
    {
        // 52 card deck
        public Card[] deck = new Card[52];

        // club = 0 | spade = 1 | heart = 2 | diamond = 3
        // fill the deck with 52 unique cards
        public void createDeck()
        {
            int arrayIndex = 0;

            for (int i = 0; i <= 3; i++) // suits
            { 
                for (int j = 2; j <= 14; j++)  // card value 2-14
                {
                    deck[arrayIndex] = new Card(j, i);  // input card value
                    arrayIndex++;
                }
            }
        }

        // fill the computer players hand with random X cards
        public List<Card> deal(int numOfCards)
        {
            HashSet<int> numbers = new HashSet<int>();  // HashSets have no duplicates
            List<Card> cards = new List<Card>();
            Random rand = new Random();     // instantiate random num gen

            // generate X random nums
            while (numbers.Count < numOfCards)
            {
                numbers.Add(rand.Next(0, deck.Length - 1));
            }

            // add X cards to a List
            foreach (int num in numbers)
            {
                cards.Add(deck[num]);
            }

            return cards;   // return List of cards
        }
    }
}
