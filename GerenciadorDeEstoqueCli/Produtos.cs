using System;


namespace GerenciadorDeEstoqueCli
{
    internal class Produtos
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public void AdicionarProduto()
        {
            Console.WriteLine("Insira o Nome do Produto");
            Nome = Console.ReadLine();

            Console.WriteLine("Insira o Preco do Produto");
            Console.Write("R$ ");
            Preco = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira a Quantidade do Produto");
            Estoque += int.Parse(Console.ReadLine());

            Console.WriteLine("Preço total: R$" + TotalPrecoProduto());
        }

        public void RemoverProduto()
        {
            Console.WriteLine("Insira a Quantidade que deseja remover do Produto");
            Estoque -= int.Parse(Console.ReadLine());
        }

        public void ListarProduto()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preco: R$" + Preco);
            Console.WriteLine("Quantidade: " + Estoque);
            Console.WriteLine("Total: R$" + TotalPrecoProduto());
        }

        private double TotalPrecoProduto()
        {
            return Estoque * Preco;
        }

    }
}
