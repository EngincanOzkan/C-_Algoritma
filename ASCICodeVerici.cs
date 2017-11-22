using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace asciKodhafta5
{
    class ASCICodeVerici
    {
        static void Main(string[] args)
        {
            string Durum = "" ;
            char HARF = ' ';
            int ASCII = 0;
            Console.WriteLine("**********************");
            Console.WriteLine("*   ASCII veya HARF   *");
            Console.WriteLine("**********************");
            Durum = Console.ReadLine();
            if (Durum == "ASCII")
            {
                Console.Clear();
                Console.Write("ASCII kodu giriniz: ");
                ASCII = int.Parse(Console.ReadLine());
                HARF = (char)ASCII;
                Console.Write("HARF : " + HARF);
            }
            else if (Durum == "HARF")
            {
                Console.Clear();
                Console.Write("HARF kodu giriniz: ");
                HARF = char.Parse(Console.ReadLine());
                ASCII = (int)HARF;
                Console.Write("ASCII KOD : " + ASCII);
            }
            else
            {
                Console.Write("Geçersiz veri girdiniz...");
                Thread.Sleep(1000);
                return;
            }
            Console.ReadKey();
        }
    }
}
