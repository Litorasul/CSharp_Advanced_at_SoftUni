using System;
using System.IO;

namespace P04.BinaryCopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string copyPath = "copyMe-copy.png";

            using (FileStream reader = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(copyPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArr = new byte[4096];

                        int size = reader.Read(byteArr, 0, byteArr.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        writer.Write(byteArr, 0, size);
                    }
                }
            }
        }
    }
}
