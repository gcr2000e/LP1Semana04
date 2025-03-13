using System;
using System.ComponentModel;
using System.Text;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Converts the args the user inputs when the project runs
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                string s = args[0];
                char dec = Convert.ToChar(args[1]);
                int count = int.Parse(args[2]);
                string decString = Decor(s, dec, count);
                Console.WriteLine(decString);
            }
            else if (args.Length != 3)
            {
                Console.WriteLine(Decor());
            }

        }

        /// <summary>
        /// Decorates a string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="count"></param>
        /// <returns>The decorated string</returns>
        private static string Decor(string s, char dec, int count)
        {
            string decString = new string(dec, count);
            return decString + s + decString; 
        }
        
        /// <summary>
        /// Error message in case the user don't put any args
        /// </summary>
        /// <returns>The error message</returns>
        private static string Decor()
        {
            Decor("User did not specify args!", '=', 3);
            return "=== User did not specify args! ===";
        }
    }
}
