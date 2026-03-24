using ArrayConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //declaração de vetor - fora do laço
        Conta[] vetConta = new Conta[3];
        double soma = 0;
        for(int i = 0; i < vetConta.Length; i++)
        {
            //instanciação de cada indice
            vetConta[i] = new Conta();
            System.Console.Write("Digite o número da conta: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Digite o titular: ");
            vetConta[i].titular = Console.ReadLine();
            System.Console.Write("Digite o saldo: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
            //soma = soma + vetConta[i].saldo;
        }
        /* soma todos os saldos e mostre
        for (int i = 0; i < vetConta.Length; i++)
        {
            vetConta[i].MostrarAtributos();
        }*/
        foreach(Conta c in vetConta)
        {
            c.MostrarAtributos();
            soma = soma + c.saldo;
        }
        System.Console.WriteLine($"Total {soma:c}");
    }
}
