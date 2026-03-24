internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.Write("Digite o ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        int idade = 2026 - ano;
        Console.WriteLine("Sua idade é: " + idade);
        if (idade >= 18)
            Console.WriteLine("Pode tirar habilitação.");
        else if (idade == 0)
            System.Console.WriteLine("Nunca tirar habilitação.");
        else
        {
            System.Console.WriteLine("Não pode tirar habilitação.");
        }
        switch (idade) // Usado para VALORES INTEIROS e em caso de IGUALDADE (comparação ==)
        {
            case 18: System.Console.WriteLine("Pode dirigir");
                     break;
            case 17: System.Console.WriteLine("Não pode");
                     break;
            default: System.Console.WriteLine("Não tem permissão");
                     break;
        }
        while (contador <= 10)
            System.Console.WriteLine(tabuada + " X " + contador + " = " + tabuada * contador);
            contador ++; // Incremento contador = contador + 1
        {
        }
        for (contador = 1; contador <= 10; contador ++)
            System.Console.WriteLine(tabuada + " X " + contador + " = " + tabuada * contador);
        System.Console.WriteLine("contador: " + contador); */
        // Estrutura de repetição do .. while
        int tabuada = 6;
        int contador = 1;
        do
        { 
            System.Console.WriteLine(tabuada + " X " + contador + " = " + tabuada * contador);
            contador += 1; // Incremento contador ++
        } while (contador <= 10);

    }
}