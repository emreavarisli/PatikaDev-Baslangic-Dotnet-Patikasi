using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        char[] sesliHarfler = GetSesliHarfler(cumle);

        Array.Sort(sesliHarfler);

        Console.WriteLine("\nSıralanmış Sesli Harfler:");
        foreach (char harf in sesliHarfler)
        {
            Console.Write(harf + " ");
        }

        Console.WriteLine();
    }

    static char[] GetSesliHarfler(string cumle)
    {
        List<char> sesliHarflerListe = new List<char>();
        string sesliHarfler = "aeiouAEIOU";

        foreach (char harf in cumle)
        {
            if (sesliHarfler.Contains(harf))
            {
                sesliHarflerListe.Add(harf);
            }
        }

        return sesliHarflerListe.ToArray();
    }
}
