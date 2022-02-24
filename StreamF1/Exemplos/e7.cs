using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace StreamF1.Exemplos
{
    public class e7
    {
        public static void ex7()
        {
            UTF8Encoding encoding = new UTF8Encoding(true);

            DESCryptoServiceProvider pv1 = new DESCryptoServiceProvider();
            pv1.Key = ASCIIEncoding.ASCII.GetBytes("admin123");
            pv1.IV = ASCIIEncoding.ASCII.GetBytes("admin456");
            //pv1.Padding = PaddingMode.PKCS7;

            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ex7.txt");

            FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            ICryptoTransform encryptor = pv1.CreateEncryptor();
            CryptoStream cs1 = new CryptoStream(fs1, encryptor, CryptoStreamMode.Write);
            byte[] cs1_data = ASCIIEncoding.ASCII.GetBytes("Bom dia! -Titio avô");
            cs1.Write(cs1_data, 0, cs1_data.Length);
            cs1.FlushFinalBlock();
            fs1.Close();
            cs1.Flush();
            FileStream fs2 = new FileStream(path, FileMode.Open, FileAccess.Read);
            ICryptoTransform decryptor = pv1.CreateDecryptor();
            CryptoStream cs2 = new CryptoStream(fs2, decryptor, CryptoStreamMode.Read);
            byte[] tmp = new byte[1024];
            int read = 0;
            Console.Write("\nConteúdo: ");
            while ((read = cs2.Read(tmp, 0, tmp.Length)) > 0) {
                Console.Write(encoding.GetString(tmp, 0, read));
            }
            fs1.Close();
            cs2.Flush();
            Console.WriteLine("\n"); // printf("\n");
            Console.WriteLine("[ex7] O ficheiro ex7.txt foi criado, lido e teve o seu conteúdo encryptado com sucesso!");
        }
    }
}
