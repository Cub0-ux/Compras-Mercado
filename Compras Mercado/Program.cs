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
            Console.Write("Adicione máximo de 10 produtos!\n");
            Console.Clear();    
            bool rodando = true;
            while(rodando)
            {
                CadNome();
                Console.WriteLine("Digite o preço do produto:");
                double price = double.Parse(Console.ReadLine());
            }

            //Listar produtos no carrinho

            //Ver valor total da compra

            //Finalizar compra e sair do sistema


            //Métodos:
            static string CadNome()
            {
                Console.WriteLine("Digite o nome do produto:");
                string nome = Console.ReadLine();
                return nome;
            }

        }
    }
}
