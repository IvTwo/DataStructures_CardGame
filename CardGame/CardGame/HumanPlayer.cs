using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal static class HumanPlayer
    {
        // variables
        public static int numOfQuestions;
        public static int numOfGuesses;

        public static void Guess()
        {
            numOfGuesses--;
        }

        public static void AskQuestion()
        {
            numOfQuestions--;
        }

        //public HumanPlayer(int numOfQuestions, int numOfGuesses)
        //{
        //    this._numOfQuestions = numOfQuestions;
        //    this._numOfGuesses= numOfGuesses;
        //}

        //// getters
        //public int getNumofQuestions()
        //{
        //    return _numOfQuestions;
        //}
        //public int getNumberOfGuesses() 
        //{
        //    return _numOfGuesses;
        //}
    }
}
