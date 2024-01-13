using System;
using System.Collections.Generic;

class OylamaUygulamasi
{
    private Dictionary<string, bool> kullaniciListesi = new Dictionary<string, bool>();
    private List<string> kategoriler = new List<string> { "Film Kategorileri", "Tech Stack Kategorileri", "Spor Kategorileri" };
    private Dictionary<string, Dictionary<string, int>> oylar = new Dictionary<string, Dictionary<string, int>>();

    private void KullaniciKaydi(string kullaniciAdi)
    {
        if (!kullaniciListesi.ContainsKey(kullaniciAdi))
        {
            kullaniciListesi[kullaniciAdi] = true;
            Console.WriteLine($"{kullaniciAdi} kullanıcısı başarıyla kaydedildi.");
        }
        else
        {
            Console.WriteLine($"{kullaniciAdi} kullanıcısı zaten kayıtlı.");
        }
    }

    private void OyVer(string kullaniciAdi, string kategori, string secenek)
    {
        if (kullaniciListesi.ContainsKey(kullaniciAdi))
        {
            if (kategoriler.Contains(kategori))
            {
                if (!oylar.ContainsKey(kategori))
                {
                    oylar[kategori] = new Dictionary<string, int>();
                }

                if (oylar[kategori].ContainsKey(secenek))
                {
                    oylar[kategori][secenek]++;
                    Console.WriteLine($"{kullaniciAdi} kullanıcısının {kategori} kategorisindeki oy işlemi başarılı.");
                }
                else
                {
                    Console.WriteLine($"{secenek} geçerli bir seçenek değil.");
                }
            }
            else
            {
                Console.WriteLine($"{kategori} geçerli bir kategori değil.");
            }
        }
        else
        {
            Console.WriteLine("Lütfen önce kayıt olun.");
        }
    }

    private void SonuclariGoster()
    {
        int toplamOySayisi = 0;
        foreach (var kategori in oylar.Keys)
        {
            int toplamKategoriOyu = 0;
            Console.WriteLine($"{kategori} Kategorisi Sonuçları:");
            foreach (var secenek in oylar[kategori].Keys)
            {
                int oySayisi = oylar[kategori][secenek];
                double yuzde = (oySayisi / (double)toplamKategoriOyu) * 100;
                Console.WriteLine($"{secenek}: {oySayisi} oy, %{yuzde:F2} oranında");
            }
            Console.WriteLine("-------------------------------");
        }
        Console.WriteLine($"Toplam Oy Sayısı: {toplamOySayisi}");
    }

    static void Main()
    {
        OylamaUygulamasi oylamaUygulamasi = new OylamaUygulamasi();

        while (true)
        {
            Console.WriteLine("\n1 - Kullanıcı Kaydı\n2 - Oy Verme\n3 - Sonuçları Gösterme\n4 - Çıkış");
            Console.Write("Lütfen bir seçenek girin: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Kullanıcı adınızı girin: ");
                string kullaniciAdi = Console.ReadLine();
                oylamaUygulamasi.KullaniciKaydi(kullaniciAdi);
            }
            else if (secim == "2")
            {
                Console.Write("Kullanıcı adınızı girin: ");
                string kullaniciAdi = Console.ReadLine();
                Console.Write("Hangi kategoriye oy vermek istiyorsunuz? (Film/Tech/Spor): ");
                string kategori = Console.ReadLine();
                Console.Write("Oyunuzu hangi seçenek için kullanmak istiyorsunuz? ");
                string secenek = Console.ReadLine();
                oylamaUygulamasi.OyVer(kullaniciAdi, kategori, secenek);
            }
            else if (secim == "3")
            {
                oylamaUygulamasi.SonuclariGoster();
            }
            else if (secim == "4")
            {
                Console.WriteLine("Uygulama sonlandırılıyor. Sonuçları görüntülemek için 3 numaralı seçeneği kullanabilirsiniz.");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz bir seçenek girdiniz. Lütfen tekrar deneyin.");
            }
        }
    }
}
