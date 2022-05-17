using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Guerreiro: Heroi
    {
        public Guerreiro(string Nome, double Vida, IArma Arma, Status Status) : base(Nome, Vida, Arma, Status) { }
    }
}
