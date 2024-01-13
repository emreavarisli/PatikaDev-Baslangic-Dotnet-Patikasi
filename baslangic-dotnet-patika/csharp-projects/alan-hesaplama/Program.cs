using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Geometrik şekli seçin (Daire, Üçgen, Kare, Dikdörtgen):");
        string sekil = Console.ReadLine();

        GeometrikSekilHesaplayici hesaplayici = new GeometrikSekilHesaplayici();

        switch (sekil.ToLower())
        {
            case "daire":
                hesaplayici.HesaplaDaire();
                break;

            case "üçgen":
                hesaplayici.HesaplaUcgen();
                break;

            case "kare":
                hesaplayici.HesaplaKare();
                break;

            case "dikdörtgen":
                hesaplayici.HesaplaDikdortgen();
                break;

            default:
                Console.WriteLine("Geçersiz bir seçim yaptınız.");
                break;
        }
    }
}

class GeometrikSekilHesaplayici
{
    public void HesaplaDaire()
    {
        Console.WriteLine("Dairenin yarıçapını girin:");
        if (double.TryParse(Console.ReadLine(), out double yaricap) && yaricap > 0)
        {
            double cevre = 2 * Math.PI * yaricap;
            double alan = Math.PI * Math.Pow(yaricap, 2);
            SonucuGoster(cevre, alan);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
        }
    }

    public void HesaplaUcgen()
    {
        Console.WriteLine("Üçgenin kenar uzunluklarını girin (a b c):");
        string[] kenarlar = Console.ReadLine().Split(' ');

        if (kenarlar.Length == 3 && double.TryParse(kenarlar[0], out double a) &&
            double.TryParse(kenarlar[1], out double b) && double.TryParse(kenarlar[2], out double c) &&
            a + b > c && a + c > b && b + c > a)
        {
            double cevre = a + b + c;
            double alan = Math.Sqrt((cevre / 2) * ((cevre / 2) - a) * ((cevre / 2) - b) * ((cevre / 2) - c));
            SonucuGoster(cevre, alan);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Kenar uzunlukları bir üçgen oluşturmalıdır.");
        }
    }

    public void HesaplaKare()
    {
        Console.WriteLine("Karenin kenar uzunluğunu girin:");
        if (double.TryParse(Console.ReadLine(), out double kenar) && kenar > 0)
        {
            double cevre = 4 * kenar;
            double alan = Math.Pow(kenar, 2);
            SonucuGoster(cevre, alan);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
        }
    }

    public void HesaplaDikdortgen()
    {
        Console.WriteLine("Dikdörtgenin uzun ve kısa kenar uzunluklarını girin (uzun kısa):");
        string[] kenarlar = Console.ReadLine().Split(' ');

        if (kenarlar.Length == 2 && double.TryParse(kenarlar[0], out double uzun) &&
            double.TryParse(kenarlar[1], out double kisa) && uzun > 0 && kisa > 0)
        {
            double cevre = 2 * (uzun + kisa);
            double alan = uzun * kisa;
            SonucuGoster(cevre, alan);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif uzunluklar girin.");
        }
    }

    private void SonucuGoster(double cevre, double alan)
    {
        Console.WriteLine($"Çevre: {cevre}, Alan: {alan}");
    }
}
