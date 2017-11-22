using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciderecedenDenkHafta5
{
    class IkinciDerecedenDenklem
    {
        static void Main(string[] args)
        {
            double kok1, kok2,delta;

            Console.WriteLine("ax^2+bx+c şeklindeki bir denklemin: ");
            Console.Write("a sayısını giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b sayısını giriniz:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c sayısını giriniz:");
            int c = int.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            if (delta >= 0)
            {
                kok1 = (-b - Math.Sqrt(delta)) / 2 * a;
                kok2 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Denklemin Kökleri={0},{1}", kok1.ToString(), kok2.ToString());
            }
            else
            {
                Console.WriteLine("Denklemin reel kökü yoktur.");
                Console.WriteLine("Denklemin Kökleri= " + (-b) + "-V¯" + delta + "i/" + 2 * a + " ve " +
                    (-b) + "+V¯" + delta + "i/" + 2 * a);
            }

            Console.ReadKey();


        }
    }
}
