using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen sayıları boşluklarla ayırarak giriniz: ");
        string girilenSayilar = Console.ReadLine();

        string[] sayiDizisi = girilenSayilar.Split(' ');

        int farkToplami = 0;
        int kareToplami = 0;

        foreach (string sayi in sayiDizisi)
        {
            int mevcutSayi;

            if (!int.TryParse(sayi, out mevcutSayi))
            {
                Console.WriteLine("Hatalı bir sayı girişi yapıldı.");
                return;
            }

            if (mevcutSayi < 67)
            {
                farkToplami += (67 - mevcutSayi);
            }
            else if (mevcutSayi > 67)
            {
                int fark = mevcutSayi - 67;
                kareToplami += fark * fark;
            }
        }

        Console.WriteLine($"Küçük olanların farklarının toplamı: {farkToplami}");
        Console.WriteLine($"Büyük olanların farklarının mutlak karelerinin toplamı: {kareToplami}");
    }
}
