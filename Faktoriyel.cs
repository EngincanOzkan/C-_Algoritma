using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyelhafta6
{
    class Faktoriyel
    {
        static void Main(string[] args)
        {
            Console.Write("faktoriyel olup olmadığını göstereceğimiz sayıyı giriniz: ");
            int sayac=0,sonuc=1,faktoriyel = int.Parse(Console.ReadLine());

            while (sonuc<faktoriyel)
            {

                sayac++;
                sonuc *= sayac;

            }

            if (sonuc == faktoriyel)
                Console.WriteLine(sayac + " ın faktoriyeli bu sayıya eşit");
            else
                Console.WriteLine("faktoriyeli bu sayıya eşit değil");

            Console.ReadKey();
        }
    }
}
