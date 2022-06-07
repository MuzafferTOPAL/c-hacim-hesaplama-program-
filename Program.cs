using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_çalışması
{
    internal class Program
    {
        static void Main(string[] args)
        { // C# Hacim Hesaplama

            Console.WriteLine("hacmini hesaplayacağınız şekli giriniz");
            Console.WriteLine("1:küp 2:üçgen prizma 3:dikdörtgen prizma 4:silindir 5: küre");
            int secim = int.Parse(Console.ReadLine());

            int kenar1;
            int küp;
            switch (secim)
            {

                case 1:
                    Console.WriteLine("küpün kenar uzunluğunu giriniz");
                    kenar1 = int.Parse(Console.ReadLine());
                    küp = kenar1 * (kenar1 * kenar1);
                    Console.WriteLine("küpün hacmi = " + küp);
                    break;

                case 2:
                    Console.WriteLine("üçgen taban alanını giriniz");
                    int taban = int.Parse(Console.ReadLine());
                    Console.WriteLine("yükseklik giriniz");
                    int yuksek = int.Parse(Console.ReadLine());

                    int ucgen = taban * yuksek;

                    Console.WriteLine("üçgen prizmanın hacmi = " + ucgen);
                    break;
                case 3:
                    Console.WriteLine("dikdörtgen prizmanın 1. kenarı giriniz ");
                    int kenar = int.Parse(Console.ReadLine());
                    Console.WriteLine("dikdörtgen prizmanın 2. kenarı giriniz");
                    int kenar2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("dikdörtgen prizmanın yuksekliğini giriniz");
                    int yuksek2 = int.Parse(Console.ReadLine());

                    int dkdrtgn = kenar * (kenar2 * yuksek2);
                    Console.WriteLine("dikdörtgen prizmanın hacmi =" + dkdrtgn);
                    break;

                case 4:
                    Console.WriteLine("silindirin hacmi için yukseklik giriniz");
                    int yuksek3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("silindirin hacmi için yarıçapı giriniz");
                    int yar = int.Parse(Console.ReadLine());

                    int silindir = 3 * (yuksek3 * yar);

                    Console.WriteLine("silindirin hacmi = " + silindir);

                    break;

                case 5:
                    Console.WriteLine("kürenin hacmi için yarı çapı giriniz");
                    int yar2 = int.Parse(Console.ReadLine());

                    int kure = (4 * 3) * (yar2 * yar2 * yar2);
                    int kure2 = kure / 3;

                    Console.WriteLine("kürenin hacmi =" + kure2);

                    break;

                default:
                    Console.WriteLine("yanlış seçim yaptınız");
                    break;
            }

            Console.ReadLine();
        }
    }
}