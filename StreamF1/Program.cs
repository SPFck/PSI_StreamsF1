using System;
using StreamF1.Exemplos;

namespace StreamF1
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            Console.WriteLine("Lista de exs:\n[1]\n[2]\n[3]\n[4]\n[5]\n[6]\n[7]\n");
            while(true)
            {
                Console.Write("\nEscolha: ");
                escolha = Console.ReadLine();
                switch(escolha)
                {
                    case "1": e1.ex1(); break;
                    case "2": e2.ex2(); break;
                    case "3": e3.ex3(); break;
                    case "4": e4.ex4(); break;
                    case "5": e5.ex5(); break;
                    case "6": e6.ex6(); break;
                    case "7": e7.ex7(); break;

                    default: Console.WriteLine("Escolha inválida!"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
