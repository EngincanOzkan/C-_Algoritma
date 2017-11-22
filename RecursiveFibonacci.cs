using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_2._1
{
    class RecursiveFibonacci
    {
        static int fibo(int x)
        {
            int onceki = 1,simdiki=0,aradeger=0;
            for (int i = 0; i < x; i++)
            {
                aradeger = simdiki;
                simdiki = onceki + simdiki;
                onceki = aradeger;

            }
            return onceki;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("satır sayısını giriniz: ");
            Console.Write(fibo(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
   }
}
