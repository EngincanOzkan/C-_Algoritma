using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_1._1
{
    class RecursiveFaktoriyel
    {
        static int fak(int x)
        {
            int CARP = 1;
            for (int i = 1; i <= x; i++)
            {
                CARP *= i;
            }
            return CARP;
        }
        static void Main(string[] args)
        {
            Console.Write("faktoriyeli alınacak sayıyı gir: ");
            Console.Write(fak(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
