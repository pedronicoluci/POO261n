// Main()
using AgregacaoVetorConta;

Cliente cli1 = new Cliente();
cli1.Nome = "Pedro";
cli1.Rg = 111;
cli1.Telefone = 998;

Cliente cli2 = new Cliente();
cli2.Nome = "Carla";
cli2.Rg = 222;
cli2.Telefone = 999;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 10000;
c1.VetTitular = new List<Cliente>();
c1.VetTitular.Add(cli1);
c1.VetTitular.Add(cli2);
foreach (var item in c1.VetTitular)
{
    item.MostrarAtributos();
}