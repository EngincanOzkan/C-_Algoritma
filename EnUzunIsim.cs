using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_5
{
    class EnUzunIsim
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "veli", "kemal", "tolga", "oktay", "fatih" };
            int maxuzunluk = isimler[0].Length;
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i].Length >= maxuzunluk)
                {
                    maxuzunluk = isimler[i].Length;
                }
            }

            int sayac=0;
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i].Length == maxuzunluk)
                {
                    sayac++;
                }
            }

            Console.Write(sayac + " adet isim bulundu, ");

            Console.Write("en çok "+maxuzunluk+" harfli ");

            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i].Length == maxuzunluk)
                {
                    Console.Write(", "+isimler[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
