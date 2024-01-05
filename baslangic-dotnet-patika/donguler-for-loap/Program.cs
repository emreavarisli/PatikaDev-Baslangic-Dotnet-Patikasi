using System;

namespace For_Loop
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Lütfen bir sayı giriniz: ");

            if (int.TryParse(Console.ReadLine(), out int sayac))
            {
                for (int i = 1; i <= sayac; i++)
                {
                    if (i % 2 == 1)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir tamsayı girin.");
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i; // tekToplam = tekToplam + i;
                else
                    ciftToplam += i; // ciftToplam = ciftToplam + i;
            }
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            // break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
