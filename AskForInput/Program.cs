using System;

namespace AskForInput
{
    /// <summary>
    /// Initializes the Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Asks the user for an integrer number and a real number and then
        /// adds them together.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.Write("Insert an integrer number: ");
            string inumber = Console.ReadLine();
            int intnumber = int.Parse(inumber);
            Console.WriteLine(intnumber);

            Console.Write("Insert a real number: ");
            string rnumber = Console.ReadLine();
            float fnumber = float.Parse(rnumber);
            Console.WriteLine($"{fnumber}\n");
            
            Console.Write($"Sum of both numbers: {intnumber + fnumber}");
        }
    }
}
