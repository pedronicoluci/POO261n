using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double precoUnitario;
        public int qtde;
        public double total;

        public void MostrarAtributos()
        {
                System.Console.WriteLine("Código: " + codigo + "\tNome: " + nome + 
                "\tPreço Unitário: " + precoUnitario + "\tQuantidade: " + qtde);
        }
        public void CalcularAumentoPreco()
        {

        }
        public void RealizarEntradaEstoque()
        {

        }
        public void RealizarSaidaEstoque()
        {

        }
        public void CalcularTotal()
        {

        }
        public void MostrarEstoqueMinimo() //< 3 qtde
        {

        }
    }
}