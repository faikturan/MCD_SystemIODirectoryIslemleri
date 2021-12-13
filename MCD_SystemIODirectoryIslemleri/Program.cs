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
           
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo DI = Directory.CreateDirectory(path);
        }




    }
}
