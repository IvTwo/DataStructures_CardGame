using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Card
    {
        // variables to hold card data
        private int _cardValue;
        private int _suit;

        // constructor
        public Card(int value, int suit)
        {
            this._cardValue = value;
            this._suit = suit;
        }

        // getters
        public int getValue()
        {
            return _cardValue;
        }
        public int getSuit()
        {
            return _suit;
        }
    }
}
