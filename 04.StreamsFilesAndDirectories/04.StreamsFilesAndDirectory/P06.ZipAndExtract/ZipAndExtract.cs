using System;
using System.IO;
using System.IO.Compression;

namespace P06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "copyMe.png";
            string zipFile = "myZip.zip";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }
    }
}
