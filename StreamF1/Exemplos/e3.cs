using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamF1.Exemplos
{
    public class e3
    {
        public static void ex3()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ex1.txt");

            if (!File.Exists(path))
            {
                Console.WriteLine("ex1.txt não existe!");
                return;
            }

            FileStream ws1 = new FileStream(path, FileMode.Append);
            UTF8Encoding encoding = new UTF8Encoding(true);
            byte[] bytes = encoding.GetBytes("\nBoas pessoal, daqui é o Feromonas!");
            ws1.Write(bytes, 0, bytes.Length);
            ws1.Close();
            Console.WriteLine("[ex3] Texto foi adicionado ao ficheiro ex1.txt com sucesso!");
        }
    }
}
