using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    public class Globin : Monstro
    {
        public double Ataque;
        public double Defesa;
        public void recebeAtaque(double AtaqueRecebido, double Defesa)
        {
            if (this.status.Vida > 0 && Defesa < AtaqueRecebido)
            {
                this.status.Vida = this.status.Vida + Defesa - AtaqueRecebido;
                Console.WriteLine("Vida Atual do Goblin " + this.nome + " : " + this.status.Vida);
                return;
            }
            Console.WriteLine("Globin " + this.nome + " está morto e não pode mais ser atacado nem Atacar");
        }
        
    }
}
