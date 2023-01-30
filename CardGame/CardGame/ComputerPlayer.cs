using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class ComputerPlayer
    {
        // holds the computers 13 cards
        public List<Card> hand = new List<Card>();

        // saved list --> duplicate of list for end reveal
        public List<Card> handSave = new List<Card>();

    }
}
