using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_3
{
    class KarekokAlma
    {
        static double kok_al(double b)
        {
            double a=1;
            do
            {
                a = (a + (b / a)) / 2;

            } while ((a * a)-b >= 0.00000000000001);

            return a;
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(kok_al(x));
            Console.ReadKey();
        }
    }
}
