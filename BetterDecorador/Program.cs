using System;
using System.ComponentModel;
using System.Text;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string s = args[0];
            char dec = Convert.ToChar(args[1]);
            int count = int.Parse(args[2]);
            string decString = Decor(s, dec, count);
            Console.WriteLine(decString);
        }

        private static string Decor(string s, char dec, int count)
        {
           string decString = new string(dec, count);

           return decString + s + decString;
        }
    }
}
