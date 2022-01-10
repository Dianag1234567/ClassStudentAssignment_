using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudentAssignment
{
    class Student
    {
        private int age;
        private string name;
        public const int MIN_AGE= 18;
        public const int MAX_AGE= 99;
        public static int numberOfMarks;

        public int Age 
        {
            get { return age; }
            set { age = (value >= MIN_AGE && value <= MAX_AGE) ? value : 0; }
        }

        public string Name { get { return name; } }

        public int Mark { get; set; }

        public string Info
        {
            get { return "Nume - " + name + " Age - " + this.Age; }
        }
        
        public Student(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

        public static int CountMarks()
        {
            return numberOfMarks++;
        }
        

    }
}
