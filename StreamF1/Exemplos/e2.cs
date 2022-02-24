using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamF1.Exemplos
{
    public class e2
    {
        public static void ex2()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ex1.txt");

            if(!File.Exists(path))
            {
                Console.WriteLine("ex1.txt não existe!");
                return;
            }

            Stream rs1 = new FileStream(path, FileMode.Open);
            byte[] tmp = new byte[10];
            int len = 0;
            UTF8Encoding encoding = new UTF8Encoding(true);
            Console.Write("\nTexto: ");
            while((len = rs1.Read(tmp, 0, tmp.Length)) > 0)
            {
                String s = encoding.GetString(tmp, 0, len);
                Console.Write(s);
            }
            rs1.Close();
            Console.WriteLine("\n"); // printf("\n");
            Console.WriteLine("[ex2] O ficheiro ex1.txt foi lido com sucesso!");
        }
    }
}
