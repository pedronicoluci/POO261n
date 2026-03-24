using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        // Encapsulamento COMPACTO (prof. vai cobrar o normal)
        public int Numero { get; set; }
        // Estabelecimento de agrgação
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }
    }
}