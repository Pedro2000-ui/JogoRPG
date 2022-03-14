using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    public class Dragao : Monstro 
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
                    Console.WriteLine("Vida Atual do Dragão " + this.nome + " : " + this.status.Vida);
                    return;
                }
                Console.WriteLine("O Dragão " + this.nome + " apresentou uma defesa maior que o ataque de seu inimigo e por isso não perdeu vida");
                return;
            }
            Console.WriteLine("Dragão " + this.nome + " está morto e não pode mais ser atacado nem Atacar");
        }
    }
}
