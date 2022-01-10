using System;

namespace ClassStudentAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string _name;
            int _age;
            double average;

            //Student 1
            Console.WriteLine("Student 1 Name: ");
            _name = Console.ReadLine();

            Console.WriteLine("Student 1 Age: ");
            _age = Convert.ToInt32(Console.ReadLine());

            Student student1 = new Student(_name, _age);

            Console.WriteLine("Student 1 Info: {0}", student1.Info);

            Console.WriteLine("Student1 has mark: ");
            student1.Mark = Convert.ToInt32(Console.ReadLine());

            Student.CountMarks();

            //Student 2
            Student student2 = new Student("Popescu", 22);
            Console.WriteLine("Student2 has mark: ");
            student2.Mark = Convert.ToInt32(Console.ReadLine());

            Student.CountMarks();

            //Student 3
            Student student3 = new Student("Popeasca", 26);

            //Student 4
            Student student4 = new Student("Loredana", 33);
            Console.WriteLine("Student4 has mark: ");
            student4.Mark = Convert.ToInt32(Console.ReadLine());

            Student.CountMarks();

            //Average of Marks:
            average = (double)(student1.Mark + student2.Mark + student3.Mark + student4.Mark) / Student.numberOfMarks;
            Console.WriteLine("Average of Marks: {0}", average);

        }
    }
}
