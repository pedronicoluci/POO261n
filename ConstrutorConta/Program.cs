// Main()
using ConstrutorConta;
Conta c1 = new Conta(); // chamada do construtor padrão
c1.MostrarAtributos();
/*System.Console.WriteLine(Conta.Contador); // get contador*/

Conta c2 = new Conta(1); // chamada do construtor 
c2.MostrarAtributos();

Conta c3 = new Conta("Ana", 100);
c3.MostrarAtributos();
System.Console.WriteLine("Qtde: " + Conta.Contador);