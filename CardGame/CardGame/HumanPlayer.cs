using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class HumanPlayer
    {
        // variables
        private int _numOfQuestions;
        private int _numOfGuesses;

        public HumanPlayer(int numOfQuestions, int numOfGuesses)
        {
            this._numOfQuestions = numOfQuestions;
            this._numOfGuesses= numOfGuesses;
        }

        // getters
        public int getNumofQuestions()
        {
            return _numOfQuestions;
        }
        public int getNumberOfGuesses() 
        {
            return _numOfGuesses;
        }
    }
}
