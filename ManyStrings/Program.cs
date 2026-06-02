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
            string message = "Good Day!";
            message = "Started Raining :( | Bad Day!";
            string dir_path = "C:\\Users\\João\\Downloads";

            Console.WriteLine(hellomsg);
            Console.WriteLine(character);
            Console.WriteLine(message);
            Console.WriteLine(dir_path);
        }
    }
}
