using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Metni ve indeksi virgülle ayırarak girin (örn: Algoritma,3):");
        string input = Console.ReadLine();

        string[] inputParts = input.Split(',');

        if (inputParts.Length == 2 && int.TryParse(inputParts[1], out int index))
        {
            string result = KarakteriCikarVeYazdir(inputParts[0], index);
            Console.WriteLine("Output: " + result);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen doğru formatta bir giriş yapın.");
        }
    }

    static string KarakteriCikarVeYazdir(string metin, int indeks)
    {
        if (indeks >= 0 && indeks < metin.Length)
        {
            return metin.Remove(indeks, 1);
        }
        else
        {
            Console.WriteLine("Geçersiz indeks. Metnin uzunluğunu aşmayan bir indeks girin.");
            return metin;
        }
    }
}
