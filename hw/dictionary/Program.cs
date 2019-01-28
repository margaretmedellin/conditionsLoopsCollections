using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //use for fruit names, change int to string
            Dictionary <int, double> studentGrades = new Dictionary<int, double> ();
            studentGrades.Add(1, 0.97);
            //adds student 1 grade of 97 to dictionary
            studentGrades.Add(2, 0.47);

            studentGrades.Add(0, .5);
            //makes the below if statement true

            //Console.WriteLine(studentGrades[1]);
            //returns student 1 grade
            Console.WriteLine(studentGrades[1].ToString("P2"));
            if (studentGrades.ContainsKey(0) == true)
            {
                
            }
            else
            {
                studentGrades.Add(0, 1.0);
            }
            Console.WriteLine(studentGrades[0]);

            Console.ReadKey();
        }
    }
}
