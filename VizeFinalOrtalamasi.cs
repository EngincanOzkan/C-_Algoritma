using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersNotuHafta5
{
    class VizeFinalOrtalamasi
    {
        static void Main(string[] args)
        {
            char durum = ' ';

            Console.WriteLine("Ortalama Hesapla---->O");
            Console.WriteLine("Geçmek İçin Gerekli Final Notu Hesapla---->F");
            Console.Write("Seçiminiz: ");
            durum = char.Parse(Console.ReadLine());

            Console.Clear();

            double vize = 0, final = 0;
            double ort=0;
            if (durum == 'O')
            {
                Console.Write("Vize notu: ");
                vize = int.Parse(Console.ReadLine());

                Console.Write("Final notu: ");
                final = int.Parse(Console.ReadLine());


                ort = (vize * 0.4) + (final * 0.6);

                if (final >= 40)
                {
                    if (ort >= 50)
                    {
                        if ((ort >= 50) && (ort <= 69)) Console.WriteLine("{0} ortalama ile ORTA ile geçtiniz.", ort);
                        else if ((ort >= 70) && (ort <= 89)) Console.WriteLine("{0} ortalama ile İYİ ile geçtiniz.", ort);
                        else Console.WriteLine("[0] ortalama ile YÜKSEK ile geçtiniz.Tebrik ediyoruz.", ort);
                    }
                    else Console.Write("Ortalamanız 50 den küçük olduğu için sınıfta kaldınız.Ortalamanız: {0}",ort);
                }
                else Console.Write("Finallerde 40 tan düşük aldığınız için sınıfta kaldınız.Ortalamanız: {0}",ort);
            }
            else
            {

                Console.Write("Vize notu: ");
                vize = int.Parse(Console.ReadLine());

                final = ((90 - (vize * 0.4)) * 10) / 6;
                if (final < 100)
                {
                    Console.WriteLine("Finallerde {0} almanız YÜKSEK ile geçmeniz için yeterli olacaktır.", final);
                }
                else
                    Console.WriteLine("Bu Sınıfı YÜKSEK derece ile geçemezsiniz bunu yapmak için almanız gereken not: {0}",final );

                final = ((70 - (vize * 0.4)) * 10) / 6;
                if (final < 100)
                {
                    Console.WriteLine("Finallerde {0} almanız İYİ ile geçmeniz için yeterli olacaktır.", final);
                }
                else Console.WriteLine("Bu Sınıfı İYİ derece ile geçemezsiniz bunu yapmak için almanız gereken not: {0}", final);


                final = ((50 - (vize * 0.4))*10)/6;
                if (final < 100)
                {
                    if (final < 40)
                    {
                        Console.WriteLine("Finallerde 40 almanız ORTA ile geçmeniz için yeterli olacaktır.");
                    }
                    else
                    {
                        Console.WriteLine("Finallerde {0} almanız ORTA ile geçmeniz için yeterli olacaktır.", final);
                    }
                }
                else Console.WriteLine("Bu Sınıfı geçemezsiniz bunu yapmak için almanız gereken not: {0}", final);
            }
            Console.ReadKey();
        }
    }
}
