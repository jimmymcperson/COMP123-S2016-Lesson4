using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
    {
    /**
    * This class is the "driver" class for our Program
    *
    * @class Program
    */
    public class Program
        {
        /**
        * The main method for our driver class Program
        *
        * @method Main
        * @param {string[]} args
        */
        public static void Main(string[] args)
            {
            //create instance of Student
            Student tommy = new Student("Tommy", 20, "S123456789");

            tommy.SaysHello();

            Console.WriteLine();

            tommy.Studies();

            Console.WriteLine();

            tommy.Courses.Add(new Course("COMP123", "Programming 2"));

            Course COMP125 = new Course("COMP125", "Client-Side Web Development"); 
            tommy.Courses.Add(COMP125);// these two lines are the same as line above

            Console.WriteLine();

            tommy.ShowCourses();

            Console.WriteLine();

            // create instance of the Teacher class
            Teacher tom = new Teacher("Tom", 47, "T123456789");

            tom.SaysHello();

            Console.WriteLine();

            tom.Teaches();

            Console.WriteLine();

            List<string> names = new List<string>();

            names.Add("Tom");
            names.Add("Mary");
            names.Add("Rutvik");


            Console.WriteLine("=========================================");
            int i = 0;
            foreach (string name in names)
                {
                Console.WriteLine("Name #" + i + " is " + name);
                i++;
                }
            Console.WriteLine("=========================================");

            Console.WriteLine();
            Console.WriteLine();

            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
            }
        public static void CreateDeck(List<Card> deck)
            {
            string suit = "";
            for (int i = 0; i < 4; i++)
                {

                switch(i)
                    {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                    }
                for (int face = 0; face < 14; face++)
                    {
                    deck.Add(new Card(face, suit));
                    }
                }
            }

        }
    }
