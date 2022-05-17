using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Dragão : Monstro
    {
        public Dragão(string Nome, double Vida, IArma Arma, Status Status) : base(Nome, Vida, Arma, Status)
        {
        }
    }
}
