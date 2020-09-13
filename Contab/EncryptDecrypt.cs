using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Contab
{
    class EncryptDecrypt
    {
        ///<summary>
        /// Encrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        public void EncryptFile(string inputFile, string outputFile)
        {
            try
            {
                const string password = @"myKey123"; // Your Key Here
                var ue = new UnicodeEncoding();
                var key = ue.GetBytes(password);

                var cryptFile = outputFile;
                var fsCrypt = new FileStream(cryptFile, FileMode.Create);

                var rmCrypto = new RijndaelManaged();

                var cs = new CryptoStream(fsCrypt,
                    rmCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                var fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();

                File.Delete(inputFile);
                File.Move(outputFile, inputFile);
            }
            catch
            {
                MessageBox.Show(@"Encryption failed!", @"Error");
            }
        }
        ///<summary>
        /// Decrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        public void DecryptFile(string inputFile, string outputFile)
        {
            try
            {
                const string password = @"myKey123"; // Your Key Here

                var ue = new UnicodeEncoding();
                var key = ue.GetBytes(password);

                var fsCrypt = new FileStream(inputFile, FileMode.Open);

                var rmCrypto = new RijndaelManaged();

                var cs = new CryptoStream(fsCrypt,
                    rmCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                var fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte) data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

                File.Delete(inputFile);
                File.Move(outputFile, inputFile);
            }
            catch
            {
                MessageBox.Show(@"Decryption failed!", @"Error");
            }
        }
    }
}
