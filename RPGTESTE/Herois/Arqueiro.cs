using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Arqueiro : Heroi
    {
        public double Flechas;
        public Arqueiro(string Nome, double Vida, double Flechas, IArma Arma, Status Status) : base(Nome, Vida, Arma, Status) 
        { 
            this.Flechas = Flechas; 
        }

        public override void Atacar(Monstro monstro)
        {
            if (this.Flechas <= 0 && this.ArmaBehavior.GetType() == typeof(Arco))
            {
                Console.WriteLine("Não é possível usar o arco! Flechas acabaram");
                SemArma novaArma = new SemArma();
                this.TrocarArma(novaArma);
            }
            this.Flechas -= 3;
            this.ArmaBehavior.UsarArma(this);
            Random rand = new Random();
            double numRandom = rand.Next((int)this.Status.Sorte);
            double ataqueHeroi = this.Status.Ataque + this.Status.Agilidade * (1 + numRandom / 100);
            Console.WriteLine($"{ this.Nome } está atacando { monstro.Nome }...");

            monstro.ReceberAtaque(ataqueHeroi);
        }
    }
}
