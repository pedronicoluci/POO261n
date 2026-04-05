using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class Conta
    {
        public int numero;
        public string? titular;
        public double saldo;
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
            }
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("----------" + "\nNúmero: " + numero + "\nTítular: " + titular + "\nSaldo: " + saldo);
        }
    }
}