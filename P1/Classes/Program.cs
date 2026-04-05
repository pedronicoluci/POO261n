using System.ComponentModel;
using Classes;

internal class Program
{   private static void Main(string[] args)
    {
    Conta[] vetConta = new Conta[3];
    for(int i=0; i < vetConta.Length; i++)
        {
            vetConta[i] = new Conta();
            Console.Write("Número da Conta: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome do Titular: ");
            vetConta[i].titular = Console.ReadLine();
            Console.Write("Saldo da Conta: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
            vetConta[i].Sacar(500);
            vetConta[i].MostrarAtributos();
        }
    }

}