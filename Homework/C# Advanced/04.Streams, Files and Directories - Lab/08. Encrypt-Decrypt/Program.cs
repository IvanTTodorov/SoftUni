using System;
using System.IO;

namespace EncryptDecrypt
{
    public class EncryptDecrypt
    {
        static void Main()
        {
            const byte secretCode = 243;

            XorEncrypted("../../../files/cat.jpg",
                "../../../files/cat-encrypted.jpg", secretCode);

            XorEncrypted("../../../files/cat-encrypted.jpg",
               "../../../files/cat-decrypted.jpg", secretCode);





        }
        static void XorEncrypted(string inputFileName, string outputFileName, byte secretCode)
        {
            using (var input = new FileStream(inputFileName, FileMode.Open))
            {
                using (var output = new FileStream(outputFileName, FileMode.Create))
                {

                    byte[] buf = new byte[1024];
                    while (true)
                    {
                        int bytesRead = input.Read(buf, 0, buf.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        Encrypt(buf, bytesRead, secretCode);
                        output.Write(buf, 0, bytesRead);
                    }
                }
            }
        }
        private static void Encrypt(byte[] buf, int bytesRead, byte secretCode)
        {
            for (int i = 0; i < bytesRead; i++)
            {
                buf[i] = (byte)(buf[i] ^ secretCode);
            }
        }
    }
}