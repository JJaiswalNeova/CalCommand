using System;
using System.Linq;

namespace CalConsole
{
    class Task1
    {
        /// <summary>
        /// Made functionality only to calculate 2 numbers as per requirements .
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            var valid = false;
            Console.Write("Sum ");
            string[] tokens = Console.ReadLine().Split(',');
            
          
            for (i = 0; i < tokens.Count(); i++)
            {

                valid = !string.IsNullOrWhiteSpace(tokens[i]) &&
                    tokens[i].All(c => c >= '0' && c <= '9');

                if (!valid)
                {
                    if ( tokens.Count() == 1 )
                    {
                        Console.WriteLine(0);
                        Console.ReadLine();  
                        return;
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
                    if( tokens.Count() <= 2)
                    {
                        n = Convert.ToInt32(tokens[i]);
                        sum += n;
                    }
                    else
                    {
                        Console.WriteLine("Error: Only two numbers are accepted.");
                        Console.ReadLine();
                        return;
                    }
                    
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }

    }
}
