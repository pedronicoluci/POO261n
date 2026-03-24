using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;
        private static int contador;
        public static int Contador // propriedade
        {
            get
            {
                return contador;
            }
        }
        public Conta() // construtor padrão
        { // nâo tem parâmetro e é concedido de forma automática a você
            contador ++;
        }

        public Conta(int numero)
        { // atributo = parâmetro
            this.numero = numero;
            contador ++;
        }

        public Conta(string? titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
            contador ++;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Número: " + numero + "\tTitular: " + titular + "\tSaldo: " + saldo);
        } // fecha método

    } // fecha da classe

} // fecha da namespace