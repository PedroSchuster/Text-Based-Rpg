using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public abstract class Personagem
    {
        public string Name { get; set; }
        public string Classe { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public Raças Raça { get; set; }

        protected Personagem(string name, string classe, int health, int level, Raças raça)
        {
            Name = name;
            Classe = classe;
            Health = health;
            Level = level;
            Raça = raça;
        }

        public virtual void Attack(int dano, Personagem inimigo)
        {
            inimigo.Health -= dano;
            Console.WriteLine(Name + " atacou " + inimigo.Name + " e deu " + dano + " de dano");
            Console.WriteLine(inimigo.Name + " tem " + inimigo.Health + " de vida");
            if(inimigo.Health <= 0)
            {
                inimigo.Morrer(this);
            }
        }

        public virtual void Morrer(Personagem inimigo)
        {
            Console.WriteLine(Name + " morreu");
        }

        public virtual void UparDeLevel()
        {
            Level += 1;
        }


        public override string ToString()
        {
            return Name + " " + Level + " " + Classe + " " + Raça + " " + Health;
        }

    }
}
