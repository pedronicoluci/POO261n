using EncapsulamentoConta;
Conta c = new Conta();
c.Numero = 1; //setNumero(1);
Console.WriteLine("Número da Conta: " + c.Numero);
// if (c.Numero > 5)
// x = c.Numero + 21;
c.Titular = "Ana";
Console.WriteLine("Nome: " + c.Titular);
c.Saldo = 100;
Console.WriteLine($"Saldo: {c.Numero:c}");