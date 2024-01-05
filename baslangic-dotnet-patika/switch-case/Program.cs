using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındayız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındayız");
                    break;
                case 3:
                    Console.WriteLine("Nisan ayındayız");
                    break;
                case 4:
                    Console.WriteLine("Mart ayındayız");
                    break;
                default:
                    Console.WriteLine("YAnlış veri girişi");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                default:
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Kış ayındasınız");
                    break;

            }
        }

    }
}