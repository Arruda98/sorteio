using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Evento
{
    class Sorteio()
    {
        public static List<int> number = new List<int>();
        public static List<int> winner = new List<int>();

        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            
            Console.WriteLine("Wellcome to Zanble Tiger\n");

            Console.WriteLine("Selecione o que deseja fazer:" +
                "\n1 - Definir números" +
                "\n2 - Listar números sorteados" +
                "\n3 - Sorteio" +
                "\n4 - Sair\n");
            double resposta = double.Parse(Console.ReadLine());

            switch(resposta)
            {
                case 1: DefinirNumero(); break;
                case 2: ListarNumeros(); break;
                case 3: SortearNumero(); break;
            }
        }

        public static void DefinirNumero()
        {
            Console.Clear();

            Console.WriteLine("Quantos pessoas serão sorteadas?");
            int quantidadeSorteada = int.Parse(Console.ReadLine());

            Random random = new Random();

            while (number.Count < quantidadeSorteada)
            {
                int valor = random.Next(1, 101);

                if (!number.Contains(valor))
                {
                    number.Add(valor);
                }
            }

            Console.WriteLine("\nNúmeros sorteados");

            foreach (int valor in number)
            {
                Console.WriteLine(valor);
            }
            Menu();
        }

        public static void ListarNumeros()
        {
            Console.Clear();

            Console.WriteLine("Números Sorteados: ");

            foreach (int valor in number)
                Console.WriteLine(valor);

            Thread.Sleep(3000);
            Menu();
        }

        public static void SortearNumero()
        {
            Console.Clear();

            Console.WriteLine("Vamos iniciar o sorteio, Boa sorte!!!");
            
            Random random = new Random();

            while (number.Count > 0)
            {
                Console.Clear();

                Console.WriteLine("Digite:\n1 - Sortear número\n2 - Sair");
                double opcao = double.Parse(Console.ReadLine());

                if (opcao == 2)
                {
                    Console.WriteLine("Você será redirecionado ao menu!");
                    break;
                }
                int numeroSorteado = random.Next(0, number.Count);

                int valor = number[numeroSorteado];

                number.RemoveAt(numeroSorteado);
                winner.Add(valor);

                Console.WriteLine($"Número sorteado: {valor}");

                Thread.Sleep(2000);
            }

            if (number.Count == 0)
                Console.WriteLine("Os números se esgotaram, adicione mais.");

            Thread.Sleep(2000);

            Menu();
        }
    }
}
