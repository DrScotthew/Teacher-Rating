//10-11-21 (Mon.)
//This program will output a professor in the form of a first name and a last name along with
//their individual grade which is received from the students who have taken the class before.
//The teacher's affiliation, helpfulness grade, and easiness grade will be shown as well.

using System;

namespace Program_3___Professor
{
    
    
        public class Professor
        {
            private string first;
            private string last;
            private string school;
            private int Grade1;
            private int Grade2;

            //These are the strings and ints used for this program.  These define them clearly.



            public Professor(string firstName, string lastName, string affiliation)
            {
                first = firstName;
                last = lastName;
                school = affiliation;

                //This is a public class with the parameters of the professor's first and last name and their school.

            }


            public Professor(string firstName, string lastName, string affiliation, int helpfulnessGrade, int easinessGrade)
            {
                first = firstName;
                last = lastName;
                school = affiliation;
                Grade1 = helpfulnessGrade;
                Grade2 = easinessGrade;

                //This is a public class with the parameters of the last public class along with a helpfulness and easiness grade. 

            }

            public string Affiliation
            {
                get
                {
                    return Affiliation;
                }

                set
                {
                    Affiliation = value;
                }
            }

            public int easinessGrade()
            {
                return Grade2;
            }

           

            public int helpfulnessGrade()
            {
                return Grade1;
            }

            

        } 
    

    

    class Program
    {
        static void Main(string[] args)
        {
            Professor name = new Professor("Jim", "Pickens", "University of Topeka Technology");

            string firstName = "Jim";
            string lastName = "Pickens";
            string affiliation = "University of Topeka Technology";
            //This defines the strings used for the rest of the code.



            Console.WriteLine("The professor's name is {0} {1} and they teach at the {2}", firstName, lastName, affiliation);
            Console.WriteLine();
            //This prints out the professor's name and the school they teach at.


            int helpfulnessGrade = 3;
            int easinessGrade = 3;

            Console.WriteLine("This professor's helpfulness grade is {0} and their easiness grade is {1}", helpfulnessGrade, easinessGrade);
            Console.WriteLine();
            //This prints out the professor's helpfulness and easiness grades.

        }

        public override string ToString()
        {
            int helpfulnessGrade = 3;

            return helpfulnessGrade.ToString();

        }

        class Program2
        {

            public override string ToString()
            {
                int easinessGrade = 3;

                return easinessGrade.ToString();
            }
        }

        
    }

}
