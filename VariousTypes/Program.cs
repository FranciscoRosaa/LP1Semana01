using System;
using System.Text;

namespace VariousTypes
{
    /// <summary>
    /// Initializes the Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Prints different types of variables.
        /// Mainly here for understanding all the different types of variables.
        /// </summary>
        /// <param name="args">Doesn't do anything.</param>
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sMaxHP = -10;
            short sidade = -18;
            sbyte slvl = -5;
            long sBossHP = -999999999;
            char Heart = '\u2764';
            byte lvl = 5;
            ushort idade = 18;
            uint MaxHP = 10;
            ulong BossHP = 999999999;

            char YinYang = '\u262F';
            char Warning = '\u26A0';
            char Watch = '\u231A';

            float HP = 1.222f;
            double d = 4186951635015115151;
            decimal dec = 2385275902707209752;

            bool verdadeiro = true;
            bool falso = false;

            Console.WriteLine(MaxHP);
            Console.WriteLine(Heart);
            Console.WriteLine(sMaxHP);
            Console.WriteLine(idade);
            Console.WriteLine(sidade);
            Console.WriteLine(lvl);
            Console.WriteLine(slvl);
            Console.WriteLine(BossHP);
            Console.WriteLine(sBossHP);
            Console.WriteLine(YinYang);
            Console.WriteLine(Warning);
            Console.WriteLine(Watch);
            Console.WriteLine(HP);
            Console.WriteLine(d);
            Console.WriteLine(dec);
            Console.WriteLine(verdadeiro);
            Console.WriteLine(falso);
        }
    }
}
