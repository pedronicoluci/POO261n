using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoExercicio
{
    public class ContaPoupanca
    {
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
            }
        }

        public void GerarRendimento()
        {
            double rendimento = Saldo * 0.01;
            Saldo += rendimento;
        }
    }
}