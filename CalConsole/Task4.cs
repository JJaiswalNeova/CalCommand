using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalConsole
{
    class Task4
    {
        /// <summary>
        /// Made functionality only to calculate multiple numbers as per requirements .
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Add ");
            var valid = false;
            string[] tokens = Console.ReadLine().Split(new Char[] { ',', '\\', 'n', ';' },
                                 StringSplitOptions.RemoveEmptyEntries);


            for (i = 0; i < tokens.Count(); i++)
            {

                valid = !string.IsNullOrWhiteSpace(tokens[i].Trim()) &&
                    tokens[i].All(c => c >= '0' && c <= '9');

                if (!valid)
                {
                    if (tokens.Count() < 1)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter number in proper format.");
                        Console.ReadLine();
                        return;
                    }
                }
                else
                {
                    n = Convert.ToInt32(tokens[i]);
                    sum += n;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
