using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{i + 1}. sayıyı giriniz: ");
            string girdi = Console.ReadLine();

            if (int.TryParse(girdi, out sayilar[i]))
            {
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Sayı giriniz.");
                i--;
            }
        }

        Array.Sort(sayilar);

        int toplamEnBuyukUc = 0;
        int toplamEnKucukUc = 0;

        Console.WriteLine("\nEn Büyük 3 Sayı:");
        for (int i = 19; i >= 17; i--)
        {
            Console.Write($"{sayilar[i]} ");
            toplamEnBuyukUc += sayilar[i];
        }

        Console.WriteLine("\n\nEn Küçük 3 Sayı:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{sayilar[i]} ");
            toplamEnKucukUc += sayilar[i];
        }

        double ortalamaEnBuyukUc = toplamEnBuyukUc / 3.0;
        double ortalamaEnKucukUc = toplamEnKucukUc / 3.0;

        Console.WriteLine($"\n\nEn Büyük 3 Sayı Ortalaması: {ortalamaEnBuyukUc}");
        Console.WriteLine($"En Küçük 3 Sayı Ortalaması: {ortalamaEnKucukUc}");

        double ortalamaToplam = (ortalamaEnBuyukUc + ortalamaEnKucukUc) / 2.0;

        Console.WriteLine($"\nToplam Ortalama: {ortalamaToplam}");
    }
}
