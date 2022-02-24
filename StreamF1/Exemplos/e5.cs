using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamF1.Exemplos
{
    public class e5
    {
        public static void ex5()
        {
            FileInfo mf = new FileInfo(Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ex5.txt"));

            mf.Directory.Create();
            FileStream fs1 = mf.Create();
            BufferedStream bs = new BufferedStream(fs1, 100000);
            UTF8Encoding encoding = new UTF8Encoding(true);
            for (int i = 1; i < 2000; i++)
            {
                byte[] bytes = encoding.GetBytes($"Linha nº{i}\n");
                bs.Write(bytes, 0, bytes.Length);
            }
            bs.Flush();
            fs1.Close();
            Console.WriteLine("[ex5] O ficheiro ex5.txt foi criado e teve suas linhas contadas com sucesso!");
        }
    }
}
