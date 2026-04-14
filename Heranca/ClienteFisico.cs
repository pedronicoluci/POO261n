using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    //               subclasse : superclasse
    //         classe derivada : Classe base
    public class ClienteFisico : Cliente
    {
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public void MostrarAtributos() {
            Console.WriteLine("RG: " + rg);
        }
        
    }
}