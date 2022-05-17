using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    abstract internal class Heroi : IPersonagem
    {
        public IArma ArmaBehavior { get; private set; }
        public Status Status { get; private set; }
        public string Nome { get; private set; }
        public Heroi(string Nome, double Vida, IArma Arma, Status Status)
        {
            this.Nome = Nome;
            this.ArmaBehavior = Arma;
            this.Status = Status;
        }

        public void TrocarArma(IArma novaArma)
        {
            this.ArmaBehavior = novaArma;
        }
        public virtual void Atacar(Monstro monstro)
        {
            if (this.Status.Vida > 0)
            {
                this.ArmaBehavior.UsarArma(this);
                Console.WriteLine(this.ArmaBehavior.GetType());
                Random rand = new Random();
                double numRandom = rand.Next((int)this.Status.Sorte);
                double ataqueHeroi = this.Status.Ataque + this.Status.Agilidade * (1 + numRandom / 100);
                Console.WriteLine($"{ this.Nome } está atacando { monstro.Nome }...");
                monstro.ReceberAtaque(ataqueHeroi);
            } else
                Console.WriteLine($"{ this.Nome } está morto e não pode mais atacar!");
        }

        public double Defender()
        {
            Random rand = new Random();
            double numRandom = rand.Next((int)this.Status.Sorte);
            return this.Status.Defesa + this.Status.Agilidade * (1 + numRandom / 100);
        }
        public virtual void ReceberAtaque(double valorDoAtaque)
        {
            Console.WriteLine($"Vida Atual de { this.Nome }: { this.Status.Vida }");
            double defesa = this.Defender();
            if (this.Status.Vida > 0)
            {
                Console.WriteLine($"{ this.Nome } está defendendo o ataque...");
                if (defesa < valorDoAtaque)
                {
                    this.Status.Vida -= (valorDoAtaque - defesa);
                    Console.WriteLine($"{ this.Nome } não conseguiu defender...");
                    Console.WriteLine($"Vida Atual de { this.Nome }: { this.Status.Vida }");
                    return;
                }
                Console.WriteLine($"O herói { this.Nome } defendeu o ataque!");
                return;
            }
            Console.WriteLine($"O herói { this.Nome } está morto e não pode mais ser atacado");
        }
    }
}
