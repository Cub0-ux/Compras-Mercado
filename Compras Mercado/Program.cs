namespace Compras_Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adicionar produto ao carrinho
            string[] produtoNome = new string[10];
            double[] valorProd = new double[10];
            int indice = 0;
            Console.Clear();
            Console.Write("Adicione máximo de 10 produtos!\n");
            bool rodando = true;
            while(rodando)
            {
                CadNome();
                CadPreco();
            }

            //Listar produtos no carrinho

            //Ver valor total da compra

            //Finalizar compra e sair do sistema


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
