using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalConsole
{
    class Task8
    {
        /// <summary>
        /// Made functionality only to calculate multiple numbers as per requirements .
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, n, x = 0, y = 0, sum = 0;
            Console.Write("Multiply ");
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
                        if (Convert.ToInt32(tokens[i]) <= 1000 && tokens.Count() == 2 && sb.Length ==0)
                        {
                            valid = Regex.Match(tokens[1].Trim(), pattern, RegexOptions.IgnoreCase).Success;
                            if (valid)
                            {

                                x = Convert.ToInt32(tokens[0]);
                                y = Convert.ToInt32(tokens[1]);
                                sum = x * y;
                            }
                            else
                            {
                                Console.WriteLine("Error: Enter correct values for multiplication.");
                                Console.ReadLine();
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Enter correct values for multiplication.");
                            Console.ReadLine();
                            return;
                        }

                    }

                }

            }
            if (sb.Length > 0)
            {
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
