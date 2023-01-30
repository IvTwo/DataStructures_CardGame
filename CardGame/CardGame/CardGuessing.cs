namespace CardGame
{
    internal class CardGuessing
    {
        static void Main(string[] args)
        {
            // run main program setup
            GameManager game = new GameManager();
            game.createDeck();

            Console.WriteLine();
            Console.ReadLine();

            // tests
            //for (int i = 0; i < game.deck.Length; i++) 
            //{ 

            //}

            //Console.WriteLine("Welcome to the Card Guessing Game!");
            //Console.WriteLine();


        }
    }
}