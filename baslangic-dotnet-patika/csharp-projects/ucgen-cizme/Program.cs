using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Üçgenin yüksekliğini girin:");

        if (int.TryParse(Console.ReadLine(), out int yukseklik))
        {
            UcgenCizme.UcgenCiz(yukseklik);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
        }
    }
}

class UcgenCizme
{
    public static void UcgenCiz(int yukseklik)
    {
        for (int i = 0; i < yukseklik; i++)
        {
            BoslukCiz(yukseklik - i - 1);
            YildizCiz(2 * i + 1);
            Console.WriteLine();
        }
    }

    private static void BoslukCiz(int adet)
    {
        for (int i = 0; i < adet; i++)
        {
            Console.Write(" ");
        }
    }

    private static void YildizCiz(int adet)
    {
        for (int i = 0; i < adet; i++)
        {
            Console.Write("*");
        }
    }
}
