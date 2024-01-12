// RehberIslemleri.cs
public static class RehberIslemleri
{
    public static void RehberiListele(TelefonRehberi rehber, string siralama)
    {
        List<string> siraliRehber;
        if (siralama == "A-Z")
        {
            siraliRehber = new List<string>(rehber.Rehber.Keys);
            siraliRehber.Sort();
        }
        else if (siralama == "Z-A")
        {
            siraliRehber = new List<string>(rehber.Rehber.Keys);
            siraliRehber.Sort((x, y) => string.Compare(y, x));
        }
        else
        {
            Console.WriteLine("Geçersiz sıralama seçeneği.");
            return;
        }

        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine(new string('*', 50));
        foreach (var kisi in siraliRehber)
        {
            Console.WriteLine($"İsim: {kisi} - Telefon Numarası: {rehber.Rehber[kisi]}");
        }
    }

    public static void RehberdeArama(TelefonRehberi rehber, string tip)
    {
        List<string> bulunanKisiler = new List<string>();

        if (tip == "1")
        {
            Console.Write("İsim veya soyisim giriniz: ");
            string kriter = Console.ReadLine();
            foreach (var kisi in rehber.Rehber.Keys)
            {
                if (kisi.ToLower().Contains(kriter.ToLower()))
                {
                    bulunanKisiler.Add(kisi);
                }
            }
        }
        else if (tip == "2")
        {
            Console.Write("Telefon numarası giriniz: ");
            string kriter = Console.ReadLine();
            foreach (var kisi in rehber.Rehber)
            {
                if (kisi.Value.Contains(kriter))
                {
                    bulunanKisiler.Add(kisi.Key);
                }
            }
        }
        else
        {
            Console.WriteLine("Geçersiz arama tipi.");
            return;
        }

        Console.WriteLine("Arama Sonuçları:");
        Console.WriteLine(new string('*', 50));
        foreach (var kisi in bulunanKisiler)
        {
            Console.WriteLine($"İsim: {kisi} - Telefon Numarası: {rehber.Rehber[kisi]}");
        }
    }
}
