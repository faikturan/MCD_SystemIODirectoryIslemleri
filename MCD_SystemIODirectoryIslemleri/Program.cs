using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIODirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("c:\\NetworkAkademi");
            //KlasorVarlikKontrolu("c:\\NetworkAkademi");
            //KlasorSilmeIslemleri("c:\\NetworkAkademi");
            //KlasorTasimaIslemleri("c:\\TasimaIslemi\\NetworkAkademi", "c:\\NetworkAkademi");

            OdevI();

            Console.ReadLine();
            
           
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo DI = Directory.CreateDirectory(path);
        }

        static void KlasorVarlikKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path);
            Console.WriteLine(kontrol);
        }

        static void KlasorSilmeIslemleri(string path)
        {
            Directory.Delete(path,true);
        }

        static void KlasorTasimaIslemleri(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef);
        }

        static void OdevI()
        {
            /*
             * C sürücüsü içerisinde NetworkAkademi adında bir klasör oluşturun oluşturmadan önce varlık kontrolü yapın eğer klasör var ise silin silerken yine kullanıcıdan silmek istiyormusunuz diye E/H ile kontrol sağlayın daha sonra oluşturun. eğer klasör yok ise oluşturun fakat adımların bilgisini ekrana yazdırın.
             */

            string dosyaYol = "c:\\NetworkAkademi";
            bool kontrol = Directory.Exists(dosyaYol);
            if (kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz klasör sistemde mevcut.");
                Console.WriteLine("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz [E/H]");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    Directory.Delete(dosyaYol, true);
                    Console.WriteLine("Dosya silme işlemi tamamlandı");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(dosyaYol + " sisteminize oluşturuluyor");
                    Directory.CreateDirectory(dosyaYol);
                }
                else
                {
                    Console.WriteLine("İşlem Bitti.");
                }
            }
            else
            {
                DirectoryInfo DI = Directory.CreateDirectory(dosyaYol);
                if (DI.Exists)
                {
                    Console.WriteLine("Dosya sitemde oluşturuldu.");
                }
            }
        }
    }
}
