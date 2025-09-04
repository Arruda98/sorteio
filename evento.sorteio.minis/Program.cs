using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Evento
{
    class Sorteio()
    {
        public static List<int> Number = new List<int>();
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("O sorteio vai começar");

            Console.WriteLine("Quantos números foram sorteados");
            int quantidadeSorteada = int.Parse(Console.ReadLine());

            double quantidade = 0;

            for (int i = 0; i < quantidadeSorteada; i++)
            {
                Random random = new Random();

                int Number = random.Next(1, 100);

            }

            Console.WriteLine(Number.Count());
            
        }
    }
}
