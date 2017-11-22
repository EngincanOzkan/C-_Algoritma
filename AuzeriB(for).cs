using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auseribhafta6
{
    class AuzeriB(for)
    {
        static void Main(string[] args)
        {
            int ust = 1;
            Console.WriteLine("a^b hesaplanması için...");
            Console.Write("a sayısını giriniz: ");
            int a = int.Parse( Console.ReadLine() );
            Console.Write("b sayısını giriniz: ");
            int b = int.Parse( Console.ReadLine() );

            for (int i = 1; i <= b; i++)
            {
                ust *= a;
            }

            Console.WriteLine("Üst = "+ust);

            Console.ReadKey();
        }
    }
}
