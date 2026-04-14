using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cliente
    {
        // declaração dos atributos
        protected int codigo;
        protected string? nome;

        // declaração dos métodos
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void MostrarAtributos() {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome);
        }
        
    }
}