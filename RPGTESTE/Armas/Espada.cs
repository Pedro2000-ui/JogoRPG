using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Espada : IArma
    {
        public void UsarArma(IPersonagem personagem) {
            personagem.Status.Forca += 15;
            personagem.Status.Agilidade -= 7;
            personagem.Status.Ataque += personagem.Status.Ataque * 0.15;
            Console.WriteLine($"{ personagem.Nome } está usando uma Espada"); 
        }
    }
}
