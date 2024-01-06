using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();

        int girilenSayi, toplamAsal = 0, toplamAsalOlmayan = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{i + 1}. sayıyı giriniz: ");
            string girdi = Console.ReadLine();

            if (int.TryParse(girdi, out girilenSayi) && girilenSayi > 0)
            {
                if (IsAsal(girilenSayi))
                {
                    asalSayilar.Add(girilenSayi);
                    toplamAsal += girilenSayi;
                }
                else
                {
                    asalOlmayanSayilar.Add(girilenSayi);
                    toplamAsalOlmayan += girilenSayi;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Pozitif sayı giriniz.");
                i--;
            }
        }

        asalSayilar.Sort();
        asalSayilar.Reverse();
        asalOlmayanSayilar.Sort();
        asalOlmayanSayilar.Reverse();

        Console.WriteLine("\nAsal Sayılar:");
        PrintArrayList(asalSayilar);

        Console.WriteLine("\nAsal Olmayan Sayılar:");
        PrintArrayList(asalOlmayanSayilar);

        Console.WriteLine($"\nAsal Sayılar Toplamı: {toplamAsal}");
        Console.WriteLine($"Asal Sayılar Ortalaması: {toplamAsal / (float)asalSayilar.Count}");

        Console.WriteLine($"\nAsal Olmayan Sayılar Toplamı: {toplamAsalOlmayan}");
        Console.WriteLine($"Asal Olmayan Sayılar Ortalaması: {toplamAsalOlmayan / (float)asalOlmayanSayilar.Count}");
    }

    static bool IsAsal(int sayi)
    {
        if (sayi < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
                return false;
        }

        return true;
    }

    static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
