using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamF1.Exemplos
{
    public class e4
    {
        public static void ex4()
        {
            FileInfo mf = new FileInfo(Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ex1.txt"));
            if(!mf.Exists)
            {
                Console.WriteLine("ex1.txt não existe!");
                return;
            }
            FileStream fs1 = mf.Open(FileMode.Truncate);
            UTF8Encoding encoding = new UTF8Encoding(true);
            byte[] bytes = encoding.GetBytes("Sopa de macaco!");
            fs1.Write(bytes, 0, bytes.Length);
            fs1.Close();
            Console.WriteLine("[ex4] Texto escrito para o ficheiro ex1.txt com sucesso!");
        }
    }
}
