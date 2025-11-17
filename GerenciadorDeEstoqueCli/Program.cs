using System;

namespace GerenciadorDeEstoqueCli
{
    class Program
    {
        static void Main()
        {
            Produtos produto;
            produto = new Produtos();

            bool saidaDoLaco = true;
            
            while (saidaDoLaco)
            {


                Console.WriteLine("-------- Digite uma opção --------");
                Console.WriteLine("[1] Adicionar produto:");
                Console.WriteLine("[2] Remover produto:");
                Console.WriteLine("[3] Listar produtos:");
                Console.WriteLine("[4] Sair do Programa:");

                int respostaUsuario = int.Parse(Console.ReadLine());

                switch (respostaUsuario)
                {
                    case 1:
                        produto.AdicionarProduto();
                        break;
                    case 2:
                        produto.RemoverProduto();
                        break;
                    case 3:
                        produto.ListarProduto();
                        break;
                    case 4:
                        saidaDoLaco = false;
                        break;
                }
            }
        }
    }
}