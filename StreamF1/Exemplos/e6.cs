using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamF1.Exemplos
{
    public class e6
    {
        public static void ex6()
        {
            MemoryStream ms1 = new MemoryStream(100);
            UTF8Encoding encoding = new UTF8Encoding(true);

            byte[] jb = Encoding.UTF8.GetBytes("Java");
            byte[] csb = Encoding.UTF8.GetBytes("CSharp");

            ms1.Write(jb, 0, jb.Length);
            ms1.Write(csb, 0, csb.Length);

            Console.WriteLine($"Capacidade: {ms1.Capacity.ToString()}\nComprimento: {ms1.Length.ToString()}\nPosição: {ms1.Position}");
            ms1.Seek(-6, SeekOrigin.Current);
            Console.WriteLine($"Nova Posição(-6): {ms1.Position}\n");
            byte[] b1 = encoding.GetBytes(" vs ");
            ms1.Write(b1, 0, b1.Length);
            byte[] allbs = ms1.GetBuffer();
            string ms1_data = encoding.GetString(allbs);
            Console.WriteLine(ms1_data);
            ms1.Flush();
            Console.WriteLine("[ex6] A MemoryStream foi escrita, lida e analisada com sucesso!");
        }
    }
}
