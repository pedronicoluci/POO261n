using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoExercicio
{
    public class ContaCorrente
    {
        public double Saldo {get; private set; }
        public double ChequeEspecial {get; set; }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }
        public void Sacar(double valor)
        {
            if(valor > 0 && valor <= Saldo + ChequeEspecial)
            {
                saldo -= valor;
            }
        }
        public void GerarExtrato(double saldo)
        {
            Console.WriteLine("Saldo Atual: " + saldo);
        }
    }
}