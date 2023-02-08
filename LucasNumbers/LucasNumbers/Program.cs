/**************************************
 * Name: Ivu
 * Date: 2/8/2023
 * 
 * Lucas Numbers Formula:
 * L(n) =
 * {
     * if n = 0 --> 2
     * if n = 1 --> 1
     * if n > 1 --> L(n-1) + L(n-2)
* }
***************************************/
namespace LucasNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The first 20 odd Lucas Numbers are: ");
            int count = 0;
            int i = 0;
            // find the first 20 ODD lucas numbers
            while(count < 20)
            {
                int number = LucasNumbers(i);
                if (number%2 == 0)   // num is even
                {
                    i++;
                }
                else    // num is odd
                {
                    i++;
                    count++;
                    Console.Write(number + ", ");
                }
            }
        }

        public static int LucasNumbers(int n)
        {
            if(n == 0)
                return 2;

            if(n == 1)
                return 1;

            // else, n > 1
            return LucasNumbers(n - 1) + LucasNumbers(n - 2);
        }
    }
}