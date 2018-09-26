using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {



                var str = System.IO.File.ReadAllText("CollectionInfo2.json");
                var ret = SimpleEncoding.UTF8ToHex(str);
                Console.WriteLine(ret);
                var ret2 = SimpleEncoding.HexToUTF8(ret);
            }
            else
            {
                Console.WriteLine("Usage");
                Console.WriteLine("Encrypt:");
                Console.WriteLine("HexEncoding -e -f=filename -o=OutputFile");
                Console.WriteLine("Decrypt:");
                Console.WriteLine("HexEncoding -d -f=filename -o=OutputFile");

            }


        }
    }



}
