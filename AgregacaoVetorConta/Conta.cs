using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVetorConta
{
    public class Conta
    {
        // Encapsulamento COMPACTO (prof. vai cobrar o normal)
        public int Numero { get; set; }
        // Estabelecimento de agrgação
        public List<Cliente> Titular { get; set; }
        public double Saldo { get; set; }
    }
}