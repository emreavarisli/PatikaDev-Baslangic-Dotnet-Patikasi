// TelefonRehberi.cs
using System;
using System.Collections.Generic;

public class TelefonRehberi
{
    public Dictionary<string, string> Rehber { get; private set; }

    public TelefonRehberi()
    {
        Rehber = new Dictionary<string, string>
        {
            {"Ali", "555-111-1111"},
            {"Ayşe", "555-222-2222"},
            {"Can", "555-333-3333"},
            {"Deniz", "555-444-4444"},
            {"Ece", "555-555-5555"}
        };
    }

    public void NumaraKaydet(string isimSoyisim, string telefon)
    {
        Rehber[isimSoyisim] = telefon;
        Console.WriteLine($"{isimSoyisim} rehbere eklendi.");
    }

    public void NumaraSil(string isimSoyisim)
    {
        if (Rehber.ContainsKey(isimSoyisim))
        {
            Rehber.Remove(isimSoyisim);
            Console.WriteLine($"{isimSoyisim} rehberden silindi.");
        }
        else
        {
            Console.WriteLine($"{isimSoyisim} rehberde bulunamadı.");
        }
    }

    public void NumaraGuncelle(string isimSoyisim, string yeniTelefon)
    {
        if (Rehber.ContainsKey(isimSoyisim))
        {
            Rehber[isimSoyisim] = yeniTelefon;
            Console.WriteLine($"{isimSoyisim} rehberde güncellendi.");
        }
        else
        {
            Console.WriteLine($"{isimSoyisim} rehberde bulunamadı.");
        }
    }

    public void RehberiListele(string siralama = "A-Z")
    {
        List<string> siraliRehber;

        if (siralama == "A-Z")
        {
            siraliRehber = new List<string>(Rehber.Keys);
            siraliRehber.Sort();
        }
        else if (siralama == "Z-A")
        {
            siraliRehber = new List<string>(Rehber.Keys);
            siraliRehber.Sort((x, y) => string.Compare(y, x));
        }
        else
        {
            Console.WriteLine("Geçersiz sıralama seçeneği.");
            return;
        }

        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine(new string('*', 50));

        foreach (var isimSoyisim in siraliRehber)
        {
            Console.WriteLine($"İsim: {isimSoyisim} - Telefon Numarası: {Rehber[isimSoyisim]}");
        }
    }
}
