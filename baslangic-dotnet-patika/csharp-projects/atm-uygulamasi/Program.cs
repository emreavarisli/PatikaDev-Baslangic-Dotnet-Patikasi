using System;
using System.Collections.Generic;
using System.IO;

class AtmUygulamasi
{
    private Dictionary<string, decimal> hesapBakiyeleri = new Dictionary<string, decimal>();
    private Dictionary<string, string> kullaniciSifreleri = new Dictionary<string, string>();
    private List<string> islemListesi = new List<string> { "Para Çekme", "Para Yatırma", "Ödeme Yapma" };
    private List<string> logs = new List<string>();

    private string kullaniciAdi;

    public AtmUygulamasi()
    {
        hesapBakiyeleri["Ahmet"] = 1000.0m;
        hesapBakiyeleri["Mehmet"] = 500.0m;
        hesapBakiyeleri["Ayşe"] = 1500.0m;

        kullaniciSifreleri["Ahmet"] = "1234";
        kullaniciSifreleri["Mehmet"] = "5678";
        kullaniciSifreleri["Ayşe"] = "abcd";
    }

    private bool GirisYap()
    {
        Console.Write("Kullanıcı Adı: ");
        string kullaniciAdi = Console.ReadLine();
        Console.Write("Şifre: ");
        string sifre = Console.ReadLine();

        if (kullaniciSifreleri.ContainsKey(kullaniciAdi) && kullaniciSifreleri[kullaniciAdi] == sifre)
        {
            this.kullaniciAdi = kullaniciAdi;
            return true;
        }
        else
        {
            Console.WriteLine("Geçersiz kullanıcı adı veya şifre. Tekrar deneyin.");
            return false;
        }
    }

    private void IslemYap()
    {
        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        for (int i = 0; i < islemListesi.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {islemListesi[i]}");
        }

        int secim;
        if (int.TryParse(Console.ReadLine(), out secim) && secim >= 1 && secim <= islemListesi.Count)
        {
            switch (secim)
            {
                case 1:
                    ParaCek();
                    break;
                case 2:
                    ParaYatir();
                    break;
                case 3:
                    OdemeYap();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
        }
    }

    private void ParaCek()
    {
        Console.Write("Çekmek istediğiniz tutarı girin: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal cekilenTutar) && cekilenTutar > 0)
        {
            if (cekilenTutar <= hesapBakiyeleri[kullaniciAdi])
            {
                hesapBakiyeleri[kullaniciAdi] -= cekilenTutar;
                LogYaz($"{kullaniciAdi} - Para Çekme - {cekilenTutar} TL");
                Console.WriteLine($"Başarıyla {cekilenTutar} TL çekildi. Güncel bakiye: {hesapBakiyeleri[kullaniciAdi]} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz tutar girişi.");
        }
    }

    private void ParaYatir()
    {
        Console.Write("Yatırmak istediğiniz tutarı girin: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal yatirilanTutar) && yatirilanTutar > 0)
        {
            hesapBakiyeleri[kullaniciAdi] += yatirilanTutar;
            LogYaz($"{kullaniciAdi} - Para Yatırma - {yatirilanTutar} TL");
            Console.WriteLine($"Başarıyla {yatirilanTutar} TL yatırıldı. Güncel bakiye: {hesapBakiyeleri[kullaniciAdi]} TL");
        }
        else
        {
            Console.WriteLine("Geçersiz tutar girişi.");
        }
    }

    private void OdemeYap()
    {
        Console.Write("Ödeme yapmak istediğiniz tutarı girin: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal odemeTutari) && odemeTutari > 0)
        {
            if (odemeTutari <= hesapBakiyeleri[kullaniciAdi])
            {
                hesapBakiyeleri[kullaniciAdi] -= odemeTutari;
                LogYaz($"{kullaniciAdi} - Ödeme Yapma - {odemeTutari} TL");
                Console.WriteLine($"Başarıyla {odemeTutari} TL ödeme yapıldı. Güncel bakiye: {hesapBakiyeleri[kullaniciAdi]} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz tutar girişi.");
        }
    }

    private void LogYaz(string log)
    {
        logs.Add(log);
    }

    private void GunSonuIslemleri()
    {
        string logDosyaAdi = $"EOD_{DateTime.Now:ddMMyyyy}.txt";

        using (StreamWriter writer = new StreamWriter(logDosyaAdi))
        {
            writer.WriteLine($"Gün Sonu Raporu - {DateTime.Now}");
            writer.WriteLine("-------------------------------");

            foreach (var log in logs)
            {
                writer.WriteLine(log);
            }

            writer.WriteLine("-------------------------------");
            writer.WriteLine("Hatalı Giriş Denemesi - 192.168.0.1 - 13:45");
        }
    }
}
