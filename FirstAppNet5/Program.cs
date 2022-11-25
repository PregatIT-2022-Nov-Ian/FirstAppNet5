using FirstAppNet5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FirstAppNet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = 9;
            double myDoubleNum = 8.99;
            char myLetter = 'A';
            bool myBoolean = false;
            string myText = "Hello World";

            Student eu = new Student();
            eu.Name = "Mircea";
            eu.Age = 100;
            //Console.WriteLine(myNum.ToString());

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //cars[1] = "Opel";
            Array.Sort(cars);
            /*
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            */
            PrintToConsole(cars);

            IEnumerable<Student> students = new List<Student>()
            {
                new Student() { Name = "Mircea", Age=100},
                new Student() { Name = "Sandra", Age=50},
            };

            PrintToConsole(students);

            IEnumerable<string> youngStudents = students
                .Where((student) => student.Age < 100)
                .Select(s => s.Name);

            var myStudent = students.FirstOrDefault(s => s.Name.StartsWith("S"));

            PrintToConsole(youngStudents);

            //Console.WriteLine(cars[1]);
            //Console.WriteLine(myText);
            //Console.WriteLine(myNum);
            Console.ReadLine(); 
        }

        static void PrintToConsole<T>(IEnumerable<T> myList)
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }

    
}
