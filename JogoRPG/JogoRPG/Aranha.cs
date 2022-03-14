using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    public class Aranha : Monstro
    {
        public double Ataque;
        public double Defesa;
        public void recebeAtaque(double AtaqueRecebido, double Defesa)
        {
            if (this.status.Vida > 0)
            {
                if (Defesa < AtaqueRecebido)
                {
                    this.status.Vida = this.status.Vida + Defesa - AtaqueRecebido;
                    Console.WriteLine("Vida Atual da Aranha " + this.nome + " : " + this.status.Vida);
                    return;
                }
                Console.WriteLine("A Aranha " + this.nome + " apresentou uma defesa maior que o ataque de seu inimigo e por isso não perdeu vida");
                return;
            }
            Console.WriteLine("Aranha " + this.nome + " está morta e não pode mais ser atacada nem Atacar");
        }
    }
}
