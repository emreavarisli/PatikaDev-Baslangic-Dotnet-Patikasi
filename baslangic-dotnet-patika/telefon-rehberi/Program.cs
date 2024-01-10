using System;

class Program
{
    static void Main()
    {
        TelefonRehberi rehber = new TelefonRehberi();

        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n(0) Çıkış");

            string secim = Console.ReadLine();

            if (secim == "0")
            {
                Console.WriteLine("Uygulamadan çıkılıyor...");
                break;
            }
            else if (secim == "1")
            {
                Console.Write("Lütfen isim giriniz: ");
                string isim = Console.ReadLine();
                Console.Write("Lütfen soyisim giriniz: ");
                string soyisim = Console.ReadLine();
                Console.Write("Lütfen telefon numarası giriniz: ");
                string telefon = Console.ReadLine();
                NumaraIslemleri.NumaraKaydet(rehber, $"{isim} {soyisim}", telefon);
            }
            else if (secim == "2")
            {
                Console.Write("Lütfen silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string aranan = Console.ReadLine();
                NumaraIslemleri.NumaraSil(rehber, aranan);
            }
            else if (secim == "3")
            {
                Console.Write("Lütfen güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string aranan = Console.ReadLine();
                NumaraIslemleri.NumaraGuncelle(rehber, aranan);
            }
            else if (secim == "4")
            {
                Console.Write("Rehberi hangi sırayla listelemek istersiniz? (A-Z veya Z-A): ");
                string siralama = Console.ReadLine();
                RehberIslemleri.RehberiListele(rehber, siralama);
            }
            else if (secim == "5")
            {
                Console.Write("Arama yapmak istediğiniz tipi seçiniz. (1: İsim/Soyisim, 2: Telefon Numarası): ");
                string tip = Console.ReadLine();
                RehberIslemleri.RehberdeArama(rehber, tip);
            }
            else
            {
                Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
            }
        }
    }
}
