using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Magia : IArma
    {
        public void UsarArma(IPersonagem personagem)
        {
            personagem.Status.Agilidade += 8;
            personagem.Status.Ataque += 10;
            personagem.Status.Vida -= 2;
            Console.WriteLine($"{ personagem.Nome } está usando Magia");
        }
    }
}
