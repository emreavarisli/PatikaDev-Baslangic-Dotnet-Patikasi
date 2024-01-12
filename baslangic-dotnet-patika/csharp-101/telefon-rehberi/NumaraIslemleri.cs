// NumaraIslemleri.cs
public static class NumaraIslemleri
{
    public static void NumaraKaydet(TelefonRehberi rehber, string isim, string soyisim, string telefon)
    {
        string adSoyad = $"{isim} {soyisim}";
        rehber.NumaraKaydet(adSoyad, telefon);
        Console.WriteLine($"{adSoyad} rehbere eklendi.");
    }

    public static bool NumaraSil(TelefonRehberi rehber, string aranan)
    {
        List<string> bulunanKisiler = new List<string>();

        foreach (var kisi in rehber.Rehber.Keys)
        {
            if (kisi.ToLower().Contains(aranan.ToLower()))
            {
                bulunanKisiler.Add(kisi);
            }
        }

        if (bulunanKisiler.Count == 0)
        {
            Console.WriteLine("Aranan kriterlere uygun veri rehberde bulunamadı.");
            return false;
        }

        Console.WriteLine("Arama Sonuçları:");
        foreach (var kisi in bulunanKisiler)
        {
            Console.WriteLine($"İsim: {kisi} - Telefon Numarası: {rehber.Rehber[kisi]}");
        }

        Console.Write("Yukarıdaki kişiyi rehberden silmek istiyor musunuz? (y/n): ");
        string onay = Console.ReadLine();
        if (onay.ToLower() == "y")
        {
            string silinecekKisi = bulunanKisiler[0];
            rehber.NumaraSil(silinecekKisi);
            Console.WriteLine($"{silinecekKisi} rehberden silindi.");
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool NumaraGuncelle(TelefonRehberi rehber, string aranan)
    {
        List<string> bulunanKisiler = new List<string>();

        foreach (var kisi in rehber.Rehber.Keys)
        {
            if (kisi.ToLower().Contains(aranan.ToLower()))
            {
                bulunanKisiler.Add(kisi);
            }
        }

        if (bulunanKisiler.Count == 0)
        {
            Console.WriteLine("Aranan kriterlere uygun veri rehberde bulunamadı.");
            return false;
        }

        Console.WriteLine("Arama Sonuçları:");
        foreach (var kisi in bulunanKisiler)
        {
            Console.WriteLine($"İsim: {kisi} - Telefon Numarası: {rehber.Rehber[kisi]}");
        }

        Console.Write("Güncel telefon numarasını giriniz: ");
        string yeniTelefon = Console.ReadLine();
        string guncellenecekKisi = bulunanKisiler[0];
        rehber.NumaraGuncelle(guncellenecekKisi, yeniTelefon);
        Console.WriteLine($"{guncellenecekKisi} rehberde güncellendi.");
        return true;
    }
}
