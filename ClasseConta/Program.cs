using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //instâcia de objeto
        Conta c1 = new Conta();
        c1.numero = 1;
        c1.titular = "Fatec";
        c1.saldo = 100;
        c1.MostrarAtributos();
        c1.Sacar(30);
        c1.MostrarAtributos();
        Conta c2 = new Conta();
        c2.Depositar(500);
        c2.MostrarAtributos(); 
        System.Console.Write("Digite o número da conta: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Digite o nome do titular da conta: ");
        c2.titular = Console.ReadLine();
        c2.MostrarAtributos();
    }
}