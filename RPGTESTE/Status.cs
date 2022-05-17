using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Status
    {
        public double Forca;
        public double Defesa;
        public double Ataque;
        public double Agilidade;
        public double Sorte;
        public double Vida;

        public Status(double Forca, double Defesa, double Ataque, double Agilidade, double Sorte, double Vida)
        {
            this.Forca = Forca;
            this.Defesa = Defesa;
            this.Ataque = Ataque;
            this.Agilidade = Agilidade;
            this.Sorte = Sorte;
            this.Vida = Vida;
        }
    }
}
