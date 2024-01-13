using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir metin giriniz: ");
        string girilenMetin = Console.ReadLine();

        if (!string.IsNullOrEmpty(girilenMetin))
        {
            string sonucMetni = IlkVeSonKarakterleriDegistir(girilenMetin);

            Console.WriteLine("Sonuç: " + sonucMetni);
        }
        else
        {
            Console.WriteLine("Girilen metin boş olmamalıdır.");
        }
    }

    static string IlkVeSonKarakterleriDegistir(string metin)
    {
        if (metin.Length <= 1)
        {
            return metin;
        }

        char[] metinDizi = metin.ToCharArray();

        char temp = metinDizi[0];
        metinDizi[0] = metinDizi[metin.Length - 1];
        metinDizi[metin.Length - 1] = temp;

        return new string(metinDizi);
    }
}
