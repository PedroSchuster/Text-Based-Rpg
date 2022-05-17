using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Mago : Personagem
    {
        public Mago(string name, string classe, int health, int level, Raças raça) : base(name, classe, health, level, raça)
        {
        }

        public override void Attack(int dano, Personagem inimigo)
        {
            base.Attack(dano, inimigo);
        }

        public override void Morrer(Personagem assassino)
        {
            base.Morrer(assassino);
            Console.WriteLine(assassino.Name + " te matou");
        }

        public override void UparDeLevel()
        {
            this.Health += 50;
            base.UparDeLevel();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
