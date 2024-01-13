using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Integer ikilileri girin (örn: 2 3 1 5):");
        string[] inputs = Console.ReadLine().Split(' ');

        List<int> numbers = new List<int>();

        for (int i = 0; i < inputs.Length; i += 2)
        {
            if (i + 1 < inputs.Length && int.TryParse(inputs[i], out int first) && int.TryParse(inputs[i + 1], out int second))
            {
                numbers.Add(first + second);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir integer ikilisi girin.");
                return;
            }
        }

        SonuclariYazdir(numbers);
    }

    static void SonuclariYazdir(List<int> sonuclar)
    {
        for (int i = 0; i < sonuclar.Count; i++)
        {
            Console.Write(sonuclar[i]);

            if (i < sonuclar.Count - 1)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}
