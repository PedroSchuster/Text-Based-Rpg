using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Inimigo : Personagem
    {
        public Inimigo(string name, string classe, int health, int level, Raças raça) : base(name, classe, health, level, raça)
        {
        }
        public override void Morrer(Personagem assassino)
        {
            base.Morrer(assassino);
            Console.WriteLine(assassino.Name + " upou de level");
            assassino.UparDeLevel();
        }

        public override void Attack(int dano, Personagem inimigo)
        {
            base.Attack(dano, inimigo);
        }

    }
}
