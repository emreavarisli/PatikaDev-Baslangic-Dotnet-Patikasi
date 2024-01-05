using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
            int[] dizi = new int[5];

            // Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanımı
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;

            foreach (var sayi in sayiDizisi)
                toplam += sayi;

            if (diziUzunlugu > 0)
            {
                double ortalama = (double)toplam / diziUzunlugu;
                Console.WriteLine("Ortalama: " + ortalama);
            }
            else
            {
                Console.WriteLine("Dizi boş, ortalama hesaplanamıyor.");
            }
        }
    }
}
