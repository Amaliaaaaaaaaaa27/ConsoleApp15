using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{ 
    // este o clasa abstracta deci nu se poate realiza instentierea

    class Entitate
    {
        private string name;
        private string nickname;
        private string age;
        private int anIncepereUniversitar;

        public Entitate(string name, string nickname, string age)
        {
            this.name = name;
            this.nickname = nickname;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public int AnIncepereUniversitar
        {
            get { return anIncepereUniversitar; }
            set { anIncepereUniversitar = value; }
        }
        public void Text()
        {
            Console.WriteLine("In programul de jos avem informatii despre cadrele scolari dar si studenti");
        }
       
    }
}
