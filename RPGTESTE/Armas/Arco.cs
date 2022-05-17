using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Arco : IArma
    {
        public void UsarArma(IPersonagem personagem) 
        {
            personagem.Status.Agilidade += 10;
            personagem.Status.Ataque += 10;
            Console.WriteLine($"{ personagem.Nome } está usando um Arco");
        }
    }
}
