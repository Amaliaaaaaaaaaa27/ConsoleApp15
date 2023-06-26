using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Studenti : Entitate
    {
        private int yearstuding;

        public Studenti(int yearstuding, string name, string nickname, string age) : base(name, nickname, age)
        {
            this.yearstuding = yearstuding;
        }
        public int YearStuding
        {
            get { return yearstuding; }
            set { yearstuding = value; }

        }
        public void Text3(int anIncepereUniversitar)
        {
            Console.WriteLine($"Universitatea incepe in anul universitar {anIncepereUniversitar}");
        } 
        public void Text2(string name, string nickname, string age)
        {
            Console.WriteLine($"Studentul are {name} {nickname} si varsta de {age}  si este in anul de studiu {this.yearstuding}");
        }
    }
}