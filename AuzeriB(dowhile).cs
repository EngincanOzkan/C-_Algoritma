using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auseribhafta6_dowhile_
{
    class AuzeriB(dowhile)
    {
        static void Main(string[] args)
        {
            int ust = 1, sayac = 0;
            Console.WriteLine("a^b hesaplanması için...");
            Console.Write("a sayısını giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b sayısını giriniz: ");
            int b = int.Parse(Console.ReadLine());

            do
            {

                ust *= a;
                sayac++;

            } while (sayac < b) ;



            Console.WriteLine("Üst = " + ust);

            Console.ReadKey();
        }
    }
}
