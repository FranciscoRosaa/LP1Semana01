using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sMaxHP = -10;
            short sidade = -18;
            sbyte slvl = -5;
            long sBossHP = -999999999;
            char copyrightSymbol = '\u2764';
            byte lvl = 5;
            ushort idade = 18;
            uint MaxHP = 10;
            ulong BossHP = 999999999;




            Console.WriteLine(MaxHP);
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(sMaxHP);
            Console.WriteLine(idade);
            Console.WriteLine(sidade);
            Console.WriteLine(lvl);
            Console.WriteLine(slvl);
            Console.WriteLine(BossHP);
            Console.WriteLine(sBossHP);
        }
    }
}
