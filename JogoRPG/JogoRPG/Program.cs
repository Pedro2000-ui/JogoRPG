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
            
                                        //Criação de Heróis//
            
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

            //Criação de um Mago
            Mago mago = new Mago();
            Status statusMago = new Status();
            statusMago.Forca = 40;
            statusMago.Defesa = 20;
            statusMago.Agilidade = 10;
            statusMago.Sorte = 20;
            statusMago.Vida = 160;
            statusMago.Mana = 45;
            mago.Ataque = statusMago.Forca + statusMago.Agilidade;
            mago.Defesa = statusMago.Defesa + statusMago.Agilidade;
            mago.nome = "Ferdinando";
            mago.status = statusMago;

                                        //Criação de Monstros//

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

            Aranha aranha = new Aranha();   
            Status statusAranha = new Status();
            statusAranha.Forca = 20;
            statusAranha.Defesa = 5;
            statusAranha.Agilidade = 35;
            statusAranha.Sorte = 10;
            statusAranha.Vida = 40;
            statusAranha.Mana = 0;
            aranha.Ataque = statusAranha.Forca + statusAranha.Agilidade;
            aranha.Defesa = statusAranha.Defesa + statusAranha.Agilidade;
            aranha.nome = "Peter Parker";
            aranha.status = statusAranha;

            Dragao dragao = new Dragao();
            Status statusDragao = new Status();
            statusDragao.Forca = 50;
            statusDragao.Defesa = 10;
            statusDragao.Agilidade = 25;
            statusDragao.Sorte = 10;
            statusDragao.Vida = 80;
            statusDragao.Mana = 0;
            dragao.Ataque = statusDragao.Forca + statusDragao.Agilidade;
            dragao.Defesa = statusDragao.Defesa + statusDragao.Agilidade;
            dragao.nome = "Banguela";
            dragao.status = statusDragao;


                                        //Batalhas
                                        //Guerreiro vs Goblin
            Console.WriteLine("Batalha 1:");
            
            while (thor.status.Vida > 0 && evolut.status.Vida > 0)
            {
                evolut.recebeAtaque(thor.atacar(thor.Ataque, thor.status.Sorte), evolut.defender(evolut.Defesa, evolut.status.Sorte));
                thor.recebeAtaque(evolut.atacar(evolut.Ataque, evolut.status.Sorte), thor.defender(thor.Defesa, thor.status.Sorte));
            }
            Console.WriteLine();
                                        //Arqueiro vs Aranha
            Console.WriteLine("Batalha 2:");
            
            while (arqueiro.status.Vida > 0 && aranha.status.Vida > 0)
            {
                aranha.recebeAtaque(arqueiro.atacar(arqueiro.Ataque, arqueiro.status.Sorte), aranha.defender(aranha.Defesa, aranha.status.Sorte));
                arqueiro.recebeAtaque(aranha.atacar(aranha.Ataque, aranha.status.Sorte), arqueiro.defender(arqueiro.Defesa, arqueiro.status.Sorte));
            }
            Console.WriteLine();
                                        //Mago vs Dragão
            Console.WriteLine("Batalha 3:");
            
            while (mago.status.Vida > 0 && dragao.status.Vida > 0)
            {
                mago.recebeAtaque(dragao.atacar(dragao.Ataque, dragao.status.Sorte), mago.defender(mago.Defesa, mago.status.Sorte));
                dragao.recebeAtaque(mago.atacar(mago.Ataque, mago.status.Sorte), dragao.defender(dragao.Defesa, dragao.status.Sorte));
            }

        }
    }
}
