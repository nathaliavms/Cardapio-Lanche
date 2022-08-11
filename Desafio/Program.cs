using System;
using System.Globalization;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Cardapio Produto = new Cardapio();

            Console.WriteLine("Digite o Código do produto desejado e a quantidade (na mesma linha):");
            string[] Numero = Console.ReadLine().Split();
            Produto.Codigo = int.Parse(Numero[0]);
            Produto.Quantidade = int.Parse(Numero[1]);

            Console.WriteLine("Total: R$ " + Produto.MultiplicarDoisValores().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
