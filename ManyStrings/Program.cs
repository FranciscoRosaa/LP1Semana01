using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string hellomsg = "Hello!";
            string character = "\u20AC";

            Console.WriteLine(hellomsg);
            Console.WriteLine(character);
        }
    }
}
