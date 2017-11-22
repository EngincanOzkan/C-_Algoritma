using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_2
{
    class ASCIileBuyutme
    {
        static char harf_buyut(char x)
        {

            x = (char)((int)x - 32);
            return x;
        }
        static void Main(string[] args)
        {
            Console.Write("Küçük harf giriniz: ");
            Console.WriteLine("Büyük harf: " + harf_buyut(char.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
