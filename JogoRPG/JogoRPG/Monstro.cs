using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    public class Monstro
    {
        public Status status;
        public int level;
        public string nome;

        public double atacar(double Ataque, int Sorte)
        {
            if(this.status.Vida > 0)
            {
                Console.WriteLine(this.nome + " está Atacando...");
                Random numAleatorio = new Random();
                double numeroSorteado = numAleatorio.Next(0, Sorte);
                double forcadoAtaque = Ataque * (1 + numeroSorteado / 100);
                Console.WriteLine("Força do ataque: " + forcadoAtaque);
                return forcadoAtaque;
            }
            Console.WriteLine("O Monstro " + this.nome + " foi morto e não pode mais atacar");
            return 0;
            
        }

        public double defender(double Defesa, int Sorte)
        {
            if(this.status.Vida > 0)
            {
                Console.WriteLine(this.nome + " está defendendo...");
                Random numAleatorio = new Random();
                double numeroSorteado = numAleatorio.Next(0, Sorte);
                double forcadaDefesa = Defesa * (1 + numeroSorteado / 100);
                Console.WriteLine("Força da defesa: " + forcadaDefesa);
                return forcadaDefesa;
            }
            return 0;
        }
    }
}
