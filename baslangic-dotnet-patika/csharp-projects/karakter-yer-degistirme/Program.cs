using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle girin:");
        string input = Console.ReadLine();

        string result = KarakterleriYerDegistir(input);
        Console.WriteLine("Output: " + result);
    }

    static string KarakterleriYerDegistir(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 1; i < charArray.Length; i += 2)
        {
            char temp = charArray[i - 1];
            charArray[i - 1] = charArray[i];
            charArray[i] = temp;
        }

        return new string(charArray);
    }
}
