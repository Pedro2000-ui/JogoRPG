using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class SemArma : IArma
    {
        public void UsarArma(IPersonagem personagem) 
        {
            Console.WriteLine($"{ personagem.Nome } não possui arma");
        }
    }
}
