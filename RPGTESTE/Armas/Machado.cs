using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Machado : IArma
    {
        public void UsarArma(IPersonagem personagem) {

            personagem.Status.Forca += 10;
            personagem.Status.Ataque += 10;
            personagem.Status.Agilidade -= 10;
            Console.WriteLine($"{ personagem.Nome } está usando um Machado");
        }
    }
}
