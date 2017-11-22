using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_3._1
{
    class RecursiveAuzeriB
    {
        static int usal(int a, int b)
        {
            int sonuc = 1;
            for (int i = 0; i < b; i++)
            {
                sonuc *= a;
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a^b  için...");

            Console.WriteLine("Sırasıyla a ve b sayısını giriniz: ");
            Console.WriteLine("Sonuc:" + usal(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
