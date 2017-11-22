using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndalikBolHafta5
{
    class OndalikliBolme
    {
        static void Main(string[] args)
        {
            Console.Write("Tam sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Ondalıklı sayı giriniz: ");
            float sayi2 = float.Parse(Console.ReadLine());
            float bolum = sayi2 / sayi1;
            Console.Write("Sayıların Bölümü: ");
            Console.Write(bolum);
            Console.ReadKey();
        }
    }
}
