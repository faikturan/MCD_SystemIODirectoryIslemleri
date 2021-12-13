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
            KlasorTasimaIslemleri("c:\\NetworkAkademi", "c:\\TasimaIslemi\\NetworkAkademi");

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


    }
}
