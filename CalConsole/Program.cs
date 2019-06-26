using System;
using System.Linq;

namespace CalConsole
{
    class Program
    {
        /// <summary>
        /// Made functionality only to calculate 2 numbers as per requirements .
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Sum ");
            string[] tokens = Console.ReadLine().Split(',');
            int[] Total = null;


            if (tokens.Count() > 0 && tokens.Count() == 1)
            {
                if (!string.IsNullOrEmpty(tokens[0].ToString()) && !string.IsNullOrWhiteSpace(tokens[0].ToString()))
                {
                    int[] sequence = { Convert.ToInt32(tokens[0].ToString()) };
                    Total = sequence;
                }
                else
                {
                    int[] sequence = { 0 };
                    Total = sequence;
                }
            }
            else if (tokens.Count() > 0 && tokens.Count() == 2)
            {
                if (!string.IsNullOrEmpty(tokens[0].ToString()) && !string.IsNullOrEmpty(tokens[1].ToString()))
                {
                    int[] sequence = { Convert.ToInt32(tokens[0].ToString()), Convert.ToInt32(tokens[1].ToString()) };
                    Total = sequence;
                }
            }
            
            // Finding sum of the given sequence 
            // Using Sum function 
            if (Total != null)
            {
                int result = Total.Sum();
                Console.WriteLine(result);
            }

            Console.ReadLine();

        }

    }
}
