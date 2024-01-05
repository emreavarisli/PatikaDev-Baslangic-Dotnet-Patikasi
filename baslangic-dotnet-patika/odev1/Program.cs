using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("***** MENÜ *****");
            Console.WriteLine("1. Kullanıcıdan çift sayıları bulma");
            Console.WriteLine("2. Kullanıcının girdiği sayılardan m'ye eşit veya tam bölünenleri bulma");
            Console.WriteLine("3. Kullanıcının girdiği kelimeleri sondan başa doğru yazdırma");
            Console.WriteLine("4. Kullanıcının girdiği cümledeki toplam kelime ve harf sayısını bulma");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminizi yapın (0-4): ");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar girin.");
                Console.Write("Seçiminizi yapın (0-4): ");
            }

            switch (choice)
            {
                case 1:
                    FindEvenNumbers();
                    break;

                case 2:
                    FindMultiplesOfM();
                    break;

                case 3:
                    ReverseWords();
                    break;

                case 4:
                    CountWordsAndLetters();
                    break;
            }

        } while (choice != 0);

        Console.WriteLine("Programdan çıkılıyor...");
    }

    static void FindEvenNumbers()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{n} adet pozitif sayı girin:");
        for (int i = 0; i < n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"Çift sayı: {num}");
            }
        }
    }

    static void FindMultiplesOfM()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Pozitif bir sayı daha girin (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{n} adet pozitif sayı girin:");
        for (int i = 0; i < n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % m == 0)
            {
                Console.WriteLine($"{num}, {m}'e tam bölünür veya eşittir.");
            }
        }
    }

    static void ReverseWords()
    {
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{n} adet kelime girin:");
        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Girilen kelimeler sondan başa:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(words[i]);
        }
    }

    static void CountWordsAndLetters()
    {
        Console.Write("Bir cümle yazın: ");
        string cumle = Console.ReadLine();

        int kelimeSayisi = cumle.Split(' ').Length;
        int harfSayisi = cumle.Replace(" ", "").Length;

        Console.WriteLine($"Toplam kelime sayısı: {kelimeSayisi}");
        Console.WriteLine($"Toplam harf sayısı: {harfSayisi}");
    }
}
