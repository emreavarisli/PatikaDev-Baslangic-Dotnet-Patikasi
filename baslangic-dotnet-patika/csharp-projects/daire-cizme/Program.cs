using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Dairenin yarıçapını girin:");

        if (double.TryParse(Console.ReadLine(), out double yaricap) && yaricap > 0)
        {
            DaireCizici.DaireCiz(yaricap);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
        }
    }
}

class DaireCizici
{
    public static void DaireCiz(double yaricap)
    {
        double cevre = CevreHesapla(yaricap);
        double alan = AlanHesapla(yaricap);

        Console.WriteLine($"Daire Çizildi - Çevre: {cevre}, Alan: {alan}");
    }

    private static double CevreHesapla(double yaricap)
    {
        return 2 * Math.PI * yaricap;
    }

    private static double AlanHesapla(double yaricap)
    {
        return Math.PI * Math.Pow(yaricap, 2);
    }
}
