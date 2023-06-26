using System;
namespace ConsoleApp15
{
    class Main1
    { 
        
            static void Main(string[] args)
            { // Am creat obiectul studenti 
                Studenti student = new Studenti(2,  "Amalia ", "Alexandra", "20");
                student.AnIncepereUniversitar = 2022;

                
                student.Text();  // Am apelat o metoda Text din clasa parinte 
                student.Text2(student.Name, student.Nickname, student.Age); // Am apelat din clasa student
                student.Text3(student.AnIncepereUniversitar);

                Console.WriteLine();

                //  obiect Profesorii
                Profesorii profesor = new Profesorii(10, "Denisa", "Mariana", "35");

                profesor.Text();  //  Am apelat o metoda Text din clasa parinte 
                profesor.Text4(profesor.Name, profesor.Nickname, profesor.Age, profesor.aniDePredare);

            }
        }
    }



  