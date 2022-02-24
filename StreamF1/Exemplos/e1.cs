using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamF1.Exemplos
{
    public class e1
    {
        public static void ex1()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ex1.txt");

            Stream ws1 = new FileStream(path, FileMode.Create);
            try
            {
                byte[] bytes = new byte[] { 65, 90, 35, 48, 49, 55 };
                if(ws1.CanWrite)
                {
                    ws1.Write(bytes, 0, bytes.Length);
                    ws1.WriteByte(48);
                } else
                {
                    Console.WriteLine("[ex1] Sem permissões de escrita!");
                }
            } catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            } finally
            {
                ws1.Close();
            }
            Console.WriteLine("[ex1] O ficheiro ex1.txt foi criado com sucesso!");
        }
    }
}
