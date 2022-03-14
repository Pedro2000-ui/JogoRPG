using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de um Guerreiro
            Guerreiro thor = new Guerreiro();
            Status statusThor = new Status();
            statusThor.Forca = 55;
            statusThor.Defesa = 40;
            statusThor.Agilidade = 10;
            statusThor.Sorte = 20;
            statusThor.Vida = 175;
            statusThor.Mana = 0;
            thor.Ataque = statusThor.Forca + statusThor.Agilidade;
            thor.Defesa = statusThor.Defesa + statusThor.Agilidade;
            thor.nome = "Deus do Trovão";
            thor.status = statusThor;

            //Criação de um Arqueiro
            Arqueiro arqueiro = new Arqueiro();
            Status statusArqueiro = new Status();
            statusArqueiro.Forca = 35;
            statusArqueiro.Defesa = 20;
            statusArqueiro.Agilidade = 25;
            statusArqueiro.Sorte = 20;
            statusArqueiro.Vida = 170;
            statusArqueiro.Mana = 30;
            arqueiro.Ataque = statusArqueiro.Forca + statusArqueiro.Agilidade;
            arqueiro.Defesa = statusArqueiro.Defesa + statusArqueiro.Agilidade;
            arqueiro.nome = "Clint";
            arqueiro.status = statusArqueiro;


            //Criação de um Goblin
            Globin evolut = new Globin();
            Status statusEvolut = new Status();
            statusEvolut.Forca = 35;
            statusEvolut.Defesa = 15;
            statusEvolut.Agilidade = 20;
            statusEvolut.Sorte = 10;
            statusEvolut.Vida = 50;
            statusEvolut.Mana = 0;
            evolut.Ataque = statusEvolut.Forca + statusEvolut.Agilidade;
            evolut.Defesa = statusEvolut.Defesa + statusEvolut.Agilidade;
            evolut.nome = "Fabianski";
            evolut.status = statusEvolut;
            

            //Ataques e Defesas
            for (int i = 0; i < 10; i++)
            {
                arqueiro.recebeAtaque(thor.atacar(thor.Ataque, thor.status.Sorte), arqueiro.defender(arqueiro.Defesa, arqueiro.status.Sorte));
                thor.recebeAtaque(arqueiro.atacar(arqueiro.Ataque, arqueiro.status.Sorte), thor.defender(thor.Defesa, thor.status.Sorte));
            }
            
        }
    }
}
