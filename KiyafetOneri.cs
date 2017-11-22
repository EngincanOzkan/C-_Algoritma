using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyafetOneri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("If - Else için-----> i");
            Console.WriteLine("Switch - Case içien --> s");
            Console.Write("Seçiminiz: ");
            char durum = char.Parse(Console.ReadLine()),havaDurumu = ' ';

            Console.WriteLine("Güneşli hava için------> g");
            Console.WriteLine("Yağmurlu hava için-----> y");
            Console.WriteLine("Karlı Hava için--------> k");
            Console.Write("Seçiminiz: ");
            havaDurumu = char.Parse(Console.ReadLine());

            if (durum != 'i')
            {

                switch (havaDurumu)
                {
                    case 'g':
                        Console.WriteLine("Gömlek Giyin");
                        break;
                    case 'y':
                        Console.WriteLine("Yağmurluk Giyin");
                        break;
                    case 'k':
                        Console.WriteLine("Mont Giyin");
                        break;
                }
            }
            else
            {

               if(havaDurumu == 'g')
                        Console.WriteLine("Gömlek Giyin");

               else if(havaDurumu == 'y')
                        Console.WriteLine("Yağmurluk Giyin");

               else if(havaDurumu == 'k')
                        Console.WriteLine("Mont Giyin");

            }
            Console.ReadKey();
        }
    }
}
