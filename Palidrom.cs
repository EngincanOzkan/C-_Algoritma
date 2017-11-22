using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_5._1
{
    class Palidrom
    {
        static string polid(string kelime)
        {
            bool polidrom = true;
            for (int i = 0; i < kelime.Length / 2; i++)
            {
                if (kelime[i] != kelime[kelime.Length - 1 - i]) polidrom = false;
            }
            if (polidrom) return "polidrom";
            else return "polidrom değil";
        }
        static void Main(string[] args)
        {
            Console.Write("Kelime giriniz: ");
            string kelime = Console.ReadLine();
            Console.Write("Kelime bir " + polid(kelime));
            Console.ReadKey();
        }
    }
}
