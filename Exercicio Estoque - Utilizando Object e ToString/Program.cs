using estoque;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os dados de um produto em estoque (nome, preço, e quantidade no estoque). Em seguida:
            //  * Mostar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque);
            //  * Realizar uma entrada no estoque e mostrar novamente os dados do produto;
            //  * Realizar uma saída no estoque e mostrar novamente os dados do produto.

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            Console.Write("Qauntidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
