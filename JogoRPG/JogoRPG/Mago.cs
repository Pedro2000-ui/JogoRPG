using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    public class Mago : Heroi
    {
        public double Ataque;
        public double Defesa;
        public double Cura;
        public void recebeAtaque(double AtaqueRecebido, double Defesa)
        {
            if (this.status.Vida > 0)
            {
                if (Defesa < AtaqueRecebido)
                {
                    this.status.Vida = this.status.Vida + Defesa - AtaqueRecebido;
                    Console.WriteLine("Vida Atual do Mago " + this.nome + " : " + this.status.Vida);
                    return;
                }
                Console.WriteLine("O Mago " + this.nome + " apresentou uma defesa maior que o ataque de seu inimigo e por isso não perdeu vida");
                return;
            }
            Console.WriteLine("Mago " + this.nome + " está morto e não pode mais ser atacado nem Atacar");
        }
    }
}
