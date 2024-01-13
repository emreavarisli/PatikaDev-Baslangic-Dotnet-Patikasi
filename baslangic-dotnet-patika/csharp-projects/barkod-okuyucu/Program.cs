using System;
using System.Drawing;
using ZXing;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - Barcode Oluştur\n2 - Barcode Oku\n3 - Çıkış");
        string secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                BarcodeOlustur();
                break;
            case "2":
                BarcodeOku();
                break;
            case "3":
                Console.WriteLine("Uygulama kapatılıyor.");
                break;
            default:
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                break;
        }
    }

    static void BarcodeOlustur()
    {
        Console.Write("Lütfen metni girin: ");
        string metin = Console.ReadLine();

        BarcodeWriter barcodeWriter = new BarcodeWriter();
        barcodeWriter.Format = BarcodeFormat.QR_CODE;

        Bitmap barcodeBitmap = barcodeWriter.Write(metin);

        Console.Write("Lütfen kaydetmek istediğiniz dosya adını girin (örneğin, barcode.png): ");
        string dosyaAdi = Console.ReadLine();

        barcodeBitmap.Save(dosyaAdi);
        Console.WriteLine($"Barcode başarıyla oluşturuldu ve {dosyaAdi} dosyasına kaydedildi.");
    }

    static void BarcodeOku()
    {
        Console.Write("Lütfen dosya adını girin (örneğin, barcode.png): ");
        string dosyaAdi = Console.ReadLine();

        BarcodeReader barcodeReader = new BarcodeReader();
        Bitmap barcodeBitmap = (Bitmap)Image.FromFile(dosyaAdi);

        Result result = barcodeReader.Decode(barcodeBitmap);

        if (result != null)
        {
            Console.WriteLine($"Okunan metin: {result.Text}");
        }
        else
        {
            Console.WriteLine("Barcode okuma başarısız oldu.");
        }
    }
}
