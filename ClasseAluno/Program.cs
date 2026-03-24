using ClasseAluno;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Criar a classe Aluno com atriutos: ra, nome, p1, p2, media. 
        Criar os métodos MostrarAtributos() e CalcularMedia()*/
        Aluno a1 = new Aluno();
        System.Console.WriteLine("Digite o RA: ");
        a1.ra = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o nome: ");
        a1.nome = Console.ReadLine();
        System.Console.WriteLine("Digite a P1: ");
        a1.p1 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Digite a P2: ");
        a1.p2 = Convert.ToDouble(Console.ReadLine());
        a1.CalcularMedia();
        a1.MostrarAtributos();
        Aluno a2 = new Aluno();
        System.Console.WriteLine("Digite o RA: ");
        a2.ra = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o nome: ");
        a2.nome = Console.ReadLine();
        System.Console.WriteLine("Digite a P1: ");
        a2.p1 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Digite a P2: ");
        a2.p2 = Convert.ToDouble(Console.ReadLine());
        a2.CalcularMedia();
        a2.MostrarAtributos();

    }
}