using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAluno
{
    public class Aluno
    {
        public int ra;
        public string nome;
        public double p1;
        public double p2;
        public double media;

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Aluno: " + nome + "\tRA: " + ra + "\tNota P1: " + p1 + "\tNota P2: " + p2 + "\tMédia: " + media);
        }
        public void CalcularMedia()
        {
            media = (p1 + p2) / 2;
        }
    }
}