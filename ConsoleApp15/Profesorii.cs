using System;

namespace ConsoleApp15
{
    class Profesorii : Entitate
    {
        public int aniDePredare;

        public Profesorii(int aniDePredare, string name, string nickname, string age)
            : base(name, nickname, age)
        {
            this.aniDePredare = aniDePredare;
        }
        public void Text4(string name, string nickname, string age, int aniDePredare)
        {
            Console.WriteLine($"Profesorul are numele {name} {nickname} , vasta {age} si este cadru didactic de {aniDePredare}");
        }
    }
}
