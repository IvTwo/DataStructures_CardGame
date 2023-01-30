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
            Console.WriteLine("work");

            for (int i = 0; i <= 3; i++) // suits
            { 
                for (int j = 2; j <= 14; j++)  // card value 2-14
                {
                    deck[arrayIndex] = new Card(j, i);  // input card value
                    arrayIndex++;
                }
            }
        }

        // fill the computer players hand with random 13 cards
        public void deal()
        {
            // generate 13 random numbers with no repeats
        }
    }
}
