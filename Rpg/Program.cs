using System;

namespace Rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mago jose = new Mago("José", "Mago", 500, 1, Raças.Humano);
            Inimigo grull = new Inimigo("Grull", "Inigo", 50, 1, Raças.Ogro);

            grull.Attack(0, jose);
            jose.Attack(50, grull);
            Console.WriteLine(jose.ToString());


        }
    }
}