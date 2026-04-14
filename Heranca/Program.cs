// Main ()
using Heranca;

Cliente c1 = new Cliente();
//"Cliente.codigo" é inacessível devido ao seu nível de proteção
//c1.codigo = 1;
c1.Codigo = 1;
c1.Nome = "Pedro";
c1.MostrarAtributos();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Alisson";
cf.Rg = 123;
cf.MostrarAtributos();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Will";
cj.Cnpj = 321;
cj.MostrarAtributos();