using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir metin giriniz: ");
        string girilenMetin = Console.ReadLine();

        if (!string.IsNullOrEmpty(girilenMetin))
        {
            bool sonuc = YanyanaIkiSessizVarMi(girilenMetin);

            Console.WriteLine(sonuc);
        }
        else
        {
            Console.WriteLine("Girilen metin boş olmamalıdır.");
        }
    }

    static bool YanyanaIkiSessizVarMi(string metin)
    {
        for (int i = 0; i < metin.Length - 1; i++)
        {
            char mevcutKarakter = Char.ToLower(metin[i]);
            char sonrakiKarakter = Char.ToLower(metin[i + 1]);

            if (sessizHarfMi(mevcutKarakter) && sessizHarfMi(sonrakiKarakter))
            {
                return true;
            }
        }

        return false;
    }

    static bool sessizHarfMi(char harf)
    {
        string sessizHarfler = "bcçdfgğhjklmnpqrsştvyz";

        return sessizHarfler.Contains(Char.ToLower(harf));
    }
}
