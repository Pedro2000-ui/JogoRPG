using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    abstract internal class Monstro : IPersonagem
    {
        public IArma ArmaBehavior { get; private set; }
        public Status Status { get; private set; }
        public string Nome { get; private set; }
        public Monstro(string Nome, double Vida, IArma arma, Status Status)
        {
            this.Nome = Nome;
            this.ArmaBehavior = arma;
            this.Status = Status;
        }

        public void Atacar(Heroi heroi)
        {
            if (this.Status.Vida > 0)
            {
                this.ArmaBehavior.UsarArma(this);
                Random rand = new Random();
                double numRandom = rand.Next((int)this.Status.Sorte);
                double ataqueMonstro = this.Status.Ataque + this.Status.Agilidade * (1 + numRandom / 100);
                Console.WriteLine($"{ this.Nome } está atacando { heroi.Nome }...");
                heroi.ReceberAtaque(ataqueMonstro);
            } else
                Console.WriteLine($"{ this.Nome } está morto e não pode mais atacar!");
        }
        public double Defender()
        {
            Random rand = new Random();
            double numRandom = rand.Next((int)this.Status.Sorte);
            return this.Status.Defesa + this.Status.Agilidade * (1 + numRandom / 100);
        }
        public void ReceberAtaque(double valorDoAtaque)
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
