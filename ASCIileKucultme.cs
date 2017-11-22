using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asciiKodkucult
{
    class ASCIileKucultme
    {
        static void Main(string[] args)
        {
            char harf;
            int buyuk;
            do
            {
                Console.Write("Harf gir:");
                harf = char.Parse(Console.ReadLine());
                buyuk = (int)harf;
                Console.WriteLine("Küçük Harf:"+(char)(buyuk+(32)));
            } while (harf != 'A');

            Console.ReadKey();
        }
    }
}
