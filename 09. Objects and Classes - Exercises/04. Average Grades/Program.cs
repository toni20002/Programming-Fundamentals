using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                string[] input = Console.ReadLine().Split();
                student.Name = input[0];
                student.Grades = input.Skip(1).Select(x => double.Parse(x)).ToList();
                students.Add(student);
                students.OrderBy(s => s.Name);
            }
            students
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => Console.WriteLine("{0} -> {1:f2}" ,s.Name ,s.AverageGrade));
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}
