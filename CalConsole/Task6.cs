using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalConsole
{
    class Task6
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
            var pattern = @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$";
            StringBuilder sb = new StringBuilder();

            for (i = 0; i < tokens.Count(); i++)
            {

                valid = Regex.Match(tokens[i].Trim(), pattern, RegexOptions.IgnoreCase).Success;
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
                    if (tokens[i].Contains("-"))
                    {
                        sb.Append(tokens[i] + ',');
                    }
                    else
                    {
                        n = Convert.ToInt32(tokens[i]);
                        sum += n;
                    }

                }

            }
            if (sb.Length > 0)
            {
                sb.ToString().TrimEnd(',');
                Console.WriteLine("Error: Negative numbers " + "(" + sb.ToString().TrimEnd(',') + ")" + " not allowed.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(sum);
                Console.ReadLine();
            }
           
        }
    }
}
