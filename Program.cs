using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading;

namespace ConsoleApp33
{
    class MM
    {

        static long size = 0;
        static void GetAllMembers(DirectoryInfo dInfo)
        {
            Console.WriteLine(" Каталог {0}", dInfo.FullName);

            FileInfo[] fInfos = dInfo.GetFiles();

            foreach (FileInfo f in fInfos)
            {
                size += f.Length;
                Console.WriteLine(" Файл {0}", f.FullName);
            }

            Console.WriteLine();
            Console.WriteLine();

            DirectoryInfo[] dirInfos = dInfo.GetDirectories();

            foreach (DirectoryInfo dinfos in dirInfos)
            {
                GetAllMembers(dinfos);
            }

        }

        static void Main(string[] args)
        {
            DirectoryInfo dInfo = new DirectoryInfo(@"D:\Temp\");

            GetAllMembers(dInfo);

            Console.WriteLine("{0}", size);

            Console.Read();
        }
    }
}