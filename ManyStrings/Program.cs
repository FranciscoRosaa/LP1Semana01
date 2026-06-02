using System;
using System.Text;

namespace ManyStrings
{
    /// <summary>
    /// Class that initializes the Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Has a lot of string variables that do different things
        /// Mainly used for testing different options when using string
        /// </summary>
        /// <param name="args">No use here!</param>
        private static void Main(string[] args)
        {   //Exercício 4
            Console.OutputEncoding = Encoding.UTF8;

            string hellomsg = "Hello!";
            string character = "\u20AC";
            string message = "Good Day!";
            message = "Started Raining :( | Bad Day!";
            string dir_path = "C:\\Users\\João\\Downloads";

            //Exercício 5
            string olamsg = "Olá " + "Mundo" + "!";
            string adeusmsg = "Adeus " + "Mundo" + "!";
            string estas = "estás?";
            string questionmsg = "Como " + estas;
            int x = 10;
            string valordex = $"O valor de x é {x}.";
            int y = 5;
            string soma = $"O valor de x + y é {x + y}";

            Console.WriteLine(hellomsg);
            Console.WriteLine(character);
            Console.WriteLine(message);
            Console.WriteLine(dir_path);
            Console.WriteLine(olamsg);
            Console.WriteLine(adeusmsg);
            Console.WriteLine(questionmsg);
            Console.WriteLine(valordex);
            Console.WriteLine(soma);
        }
    }
}
