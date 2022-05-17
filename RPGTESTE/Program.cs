using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arqueiro guerreiro = new Arqueiro("Pedro", 100, 3 , new Arco(), new Status(100,50,80,10,10,100));
            Goblin goblin = new Goblin("Joao", 100, new Espada(), new Status(80,50,50,5,5,100));
            
            goblin.Atacar(guerreiro);
            guerreiro.Atacar(goblin);
            goblin.Atacar(guerreiro);
            guerreiro.Atacar(goblin);
            guerreiro.TrocarArma(new Espada());
            guerreiro.Atacar(goblin);
        }
    }
}
