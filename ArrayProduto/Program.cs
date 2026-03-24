using ArrayProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto[] vetProduto = new Produto[3];
        for(int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i] = new Produto();
            System.Console.Write("Digite o código do produto: ");
            vetProduto[i].codigo = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Digite o nome do produto: ");
            vetProduto[i].nome = Console.ReadLine();
            System.Console.Write("Digite o preço unitário do produto: ");
            vetProduto[i].precoUnitario = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Digite a quantidade em estoque: ");
            vetProduto[i].qtde = Convert.ToInt32(Console.ReadLine());
        }

        System.Console.WriteLine("\n----- Produtos Cadastrados -----");
        foreach(Produto p in vetProduto)
        {
            p.MostrarAtributos();
        }

    System.Console.WriteLine("\nMenu de Opções:");
    System.Console.WriteLine("1 - Mostrar Produtos Cadastrados");
    System.Console.WriteLine("2 - Calcular o aumento do preço");
    System.Console.WriteLine("3 - Realizar entrada no estoque");
    System.Console.WriteLine("4 - Realizar saída no estoque");
    System.Console.WriteLine("5 - Calcular total em estoque");
    System.Console.WriteLine("6 - Mostrar estoque mínimo");
    System.Console.Write("Digite a opção desejada: ");
    int opcao = Console.ReadLine();
    while (opcao < 7)
    {
        
    }
    }
}