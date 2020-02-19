using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Gama.Calculadora.Console
{
    public static class Colecoes
    {
        //<summary>
        // Arrays são coleções não dinâmicas, ou seja, não se adiciona em tempo
        //de execução.
        //</summary>
        public static void TrabalhandoComArray()
        {
            var nomes = new string[5];
            nomes[0] = "Amanda";
            nomes[1] = "Danilo";
            nomes[2] = "Julia";
            nomes[3] = "Navi";
            nomes[4] = "Quico";

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(nomes[i]);
            }
        }

        public static void TrabalhandoComLista()
        {
            var nomes = new List<string>()
            {
                "Amanda",
                "Danilo"
            };


            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                System.Console.WriteLine("Informe o Nome:");

                var novo = System.Console.ReadLine();

                nomes.Add(novo);

                System.Console.Clear();
            }
        }

        public static void TrabalhandoComFila()
        {
            var nomes = new Queue<string>();

            nomes.Enqueue("Joana");
            nomes.Enqueue("Maria");
            nomes.Enqueue("Clarice");

            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                //System.Console.WriteLine("Insira um nome:");
                System.Console.WriteLine("Pressione qualquer tecla para retirar da fila:");

                //var novo = System.Console.ReadLine();
                //nomes.Enqueue(novo);

                System.Console.ReadKey();
                nomes.Dequeue();

                System.Console.Clear();
            }
        }

        public static void TrabalhandoComPilha()
        {
            var nomes = new Stack<string>();

            nomes.Push("Joana");
            nomes.Push("Maria");
            nomes.Push("Clarice");

            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                //System.Console.WriteLine("Insira um nome:");
                System.Console.WriteLine("Pressione qualquer tecla para retirar da pilha:");

                //var novo = System.Console.ReadLine();
                //nomes.Enqueue(novo);

                System.Console.ReadKey();
                nomes.Pop();

                System.Console.Clear();
            }
        }

        public static void TrabalhandoComDicionario()
        {
            var nomes = new Dictionary<string, int>();

            nomes.Add("joana", 22);
            nomes.Add("amanda", 32);
            nomes.Add("joyce", 32);
            nomes.Add("bruna", 13);

            nomes
                .OrderBy(item => item.Key)
                .OrderBy(item => item.Value)
                .ToList()
                .ForEach(x => System.Console.WriteLine(x));
        }

        public static void FiltrandoLista()
        {
            var nomes = new List<string>()
            {
                "Um",
                "Dois",
                "Tres",
                "Dois"
            };

            nomes
                .OrderByDescending(nome => nome)
                .ToList()
                .ForEach(nome => System.Console.WriteLine(nome));

            System.Console.WriteLine("\n");

            nomes.ForEach(x => System.Console.WriteLine(x));
        }
    }
}
