using ChecksumCheck.Cmdl.Helper;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class Checksum
{
    public string CheckFile(string Path, int Type)
    {
        StringBuilder buff = new StringBuilder();

        switch (Type)
        {
            case 1:
                {
                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                    FileStream f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    md5.ComputeHash(f);
                    byte[] hash = md5.Hash;
                    //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                    //					byte hashByte = 0;
                    foreach (byte hashByte in hash)
                    {
                        buff.Append(string.Format("{0:X2}", hashByte));
                    }
                    f.Close();
                    break;
                }
            case 2:
                {
                    SHA1CryptoServiceProvider md5 = new SHA1CryptoServiceProvider();
                    FileStream f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    md5.ComputeHash(f);
                    byte[] hash = md5.Hash;
                    //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                    //					byte hashByte = 0;
                    foreach (byte hashByte in hash)
                    {
                        buff.Append(string.Format("{0:X2}", hashByte));
                    }
                    f.Close();
                    break;
                }
            case 3:
                {
                    SHA256CryptoServiceProvider md5 = new SHA256CryptoServiceProvider();
                    FileStream f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    md5.ComputeHash(f);
                    byte[] hash = md5.Hash;
                    //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                    //					byte hashByte = 0;
                    foreach (byte hashByte in hash)
                    {
                        buff.Append(string.Format("{0:X2}", hashByte));
                    }
                    f.Close();
                    break;
                }
            case 4:
                {
                    SHA512CryptoServiceProvider md5 = new SHA512CryptoServiceProvider();
                    FileStream f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    md5.ComputeHash(f);
                    byte[] hash = md5.Hash;
                    //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                    //					byte hashByte = 0;
                    foreach (byte hashByte in hash)
                    {
                        buff.Append(string.Format("{0:X2}", hashByte));
                    }
                    f.Close();
                    break;
                }
            case 5:
                {
                    Crc32 crc32 = new Crc32();
                    FileStream f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    f = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
                    crc32.ComputeHash(f);
                    byte[] hash = crc32.Hash;
                    //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                    //				byte hashByte = 0;
                    foreach (byte hashByte in hash)
                    {
                        buff.Append(string.Format("{0:X2}", hashByte));
                    }
                    //Dim crc32 As New Crc32
                    //Dim hash As String = ""
                    //Using fs As FileStream = File.Open(Path, FileMode.Open)
                    //    For Each b As Byte In crc32.ComputeHash(fs)
                    //        hash &= b.ToString("x2").ToLower()
                    //    Next
                    //End Using
                    //buff.Append(hash)
                    break;
                }
        }

        return buff.ToString().ToLower();
    }
}