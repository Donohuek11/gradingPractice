using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            string grade;
            Console.Write("What is your gpa: ");
            bool parseOkay = double.TryParse(Console.ReadLine(), out gpa);
            if (parseOkay == true)
            {
                if (gpa >= 4.0)
                {
                    grade = "A";
                    Console.WriteLine("Your grade is a {0}", grade);

                }
           else if (gpa < 4.0 && gpa >= 3.0)
                {
                    grade = "B";
                    Console.WriteLine("Your grade is a {0}", grade);

                }

                else if (gpa < 3.0 && gpa >= 2.0)
                {
                    grade = "C";
                    Console.WriteLine("Your grade is a {0}", grade);

                }

                else if (gpa < 2.0 && gpa >= 1.0)
                {
                    grade = "D";
                    Console.WriteLine("Your grade is a {0}", grade);

                }

                else if (gpa < 1.0 && gpa >= 0)
                {
                    grade = "F";
                    Console.WriteLine("Your grade is a {0}", grade);

                }
                else
                {
                    Console.WriteLine("That is a negative number");
                }
            }
            else
            {
                Console.WriteLine("That is invalid");
            }




            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        
        }
    }
}
