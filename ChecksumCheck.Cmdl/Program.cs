using System;

namespace ChecksumCheck.Cmdl
{
    class Program
    {
        public static void Main(string[] args)
        {
            Checksum checker = new Checksum();
            //initialization
            string filePath = args[0];
            try
            {
                string hashType = args[1];
                if (!(args[0].Length == 0))
                {
                    if (hashType.Contains("-MD5") || hashType.Contains("-md5")) PrintOut(checker.CheckFile(filePath, 1));
                    else if (hashType.Contains("-SHA1") || hashType.Contains("-sha1")) PrintOut(checker.CheckFile(filePath, 2));
                    else if (hashType.Contains("-SHA256") || hashType.Contains("-sha256")) PrintOut(checker.CheckFile(filePath, 3));
                    else if (hashType.Contains("-SHA512") || hashType.Contains("-sha512")) PrintOut(checker.CheckFile(filePath, 4));
                    else if (hashType.Contains("-CRC32") || hashType.Contains("-crc32")) PrintOut(checker.CheckFile(filePath, 5));
                    else PrintOut("Command Not found");
                }
            }
            catch
            {
                PrintOut("An error occured");
            }
        }

        //check Process

        public static void PrintOut(string result)
        {
            Console.WriteLine(result);
        }
    }
}