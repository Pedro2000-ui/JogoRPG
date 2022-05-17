using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Mago : Heroi
    {
        public double Mana { get; private set; }
        public Mago(string Nome, double Vida, double Mana, IArma Arma, Status Status) : base(Nome, Vida, Arma, Status)
        {
            this.Mana = Mana;
        }

        public override void Atacar(Monstro monstro)
        {
            if (this.Mana <= 0 && this.ArmaBehavior.GetType() == typeof(Magia))
            {
                Console.WriteLine("Não é possível usar Magia! A mana acabou");
                SemArma novaArma = new SemArma();
                this.TrocarArma(novaArma);
            }
            this.Mana -= 8;
            this.ArmaBehavior.UsarArma(this);
            
            Random rand = new Random();
            double numRandom = rand.Next((int)this.Status.Sorte);
            double ataqueHeroi = this.Status.Ataque + this.Status.Agilidade * (1 + numRandom / 100);
            Console.WriteLine($"{ this.Nome } está atacando { monstro.Nome }...");
        }

        public override void ReceberAtaque(double valorDoAtaque)
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
                    this.CurarOuRessuscitar();
                    return;
                }
                Console.WriteLine($"O herói { this.Nome } defendeu o ataque!");
                return;
            }
            Console.WriteLine($"O herói { this.Nome } está morto e não pode mais ser atacado");
        }

        public void CurarOuRessuscitar()
        {
            if (this.Status.Vida > 0)
            {
                Console.WriteLine($"{ this.Nome } está se curando...");
                this.Mana -= 5;
                this.Status.Vida += 10;
            }
            else if (this.Mana > 0)
            {
                this.Mana = 0; //Perde toda a mana, dá sorte se tiver pouca quando morrer e azar se tiver muita!
                this.Status.Vida = 100;
                Console.WriteLine($"{ this.Nome } voltou a vida!");
            }
        }
    }
}
