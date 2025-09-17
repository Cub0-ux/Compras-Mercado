namespace Compras_Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtoNome = new string[10];
            double[] valorProd = new double[10];
            int indice = 0;
            Console.Clear();
            Console.Write("Adicione máximo de 10 produtos!\n");
            bool rodando = true;
            while(rodando)
            {
                Console.WriteLine("Selecione uma das opções:\n" +
                                  "1 - Adicionar produto ao carrinho\n" +
                                  "2 - Lista dos produtos do carrinho\n" +
                                  "3 - Valor total da compra\n" +
                                  "4 - Finalizar compra(pagamento)");
                int botao = 0;
                if (!int.TryParse(Console.ReadLine(), out botao))
                {
                    Console.WriteLine("Opção inválida, digite apenas números!");
                    Console.ReadKey();
                    continue;
                }
                switch (botao)
                {
                    //Adicionar produto ao carrinho
                    case 1:
                        string nome = CadNome();
                        double preco = CadPreco();
                        produtoNome[indice] = nome;
                        valorProd[indice] = preco;
                        Console.WriteLine("Compra adicionada ao carrinho!");
                        Console.WriteLine("Deseja adicionar outro produto?");
                        int botao2 = 0;
                        if (!int.TryParse(Console.ReadLine(), out botao2))
                            return;
                        switch(botao2)
                        {
                            case 1:

                                break;
                            case 2:

                                break;
                            default:
                                Console.WriteLine("Selecione uma opção válida!");
                                break;
                        }
                        indice++;
                        break;
                    //Lista de produtos no carrinho
                    case 2:
                        Console.WriteLine("Compras incluidas:");
                        if(indice == 0)
                        {
                            Console.WriteLine("Compra não adicionada");
                        }
                        for(int i = 0; i < indice; i++)
                        {
                            Console.WriteLine($"{i + 1} = {produtoNome[i]} ||R${valorProd[i]}||");
                        }
                        break;
                    //Valor total da compra
                    case 3:
                        Console.WriteLine("Valor total da compra:");

                        break;
                    //Finalizar compra(pagamento)
                    case 4:
                        Console.WriteLine("Efetue o pagamento");
                        Console.WriteLine("Obrigado pela preferência!");
                        rodando = false;
                        break;
                    default:
                        Console.WriteLine("Digite apenas uma das opções do menu!");
                        break;
                }

            }

            //Funções:
            static string CadNome()
            {
                Console.WriteLine("Digite o nome do produto:");
                string nome = Console.ReadLine();
                return nome;
            }
            static double CadPreco()
            {
                Console.WriteLine("Digite o preço do produto:");
                double price = double.Parse(Console.ReadLine());
                return price;
            }

        }
    }
}
