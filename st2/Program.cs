using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Sasha");
            Student student3 = new Student("Roma", 19);
            Student student4 = new Student("Gosha", 21, "SIS", 4.6);

            student1.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();
            student4.PrintInfo();

            Console.WriteLine(Student.GetTotalStudents());
        }
    }
    class Student
    {
        public string Name;
        public int Age;
        public string Group;
        public double AverageGrade;
        private static int totalStudents = 0;
        public Student()
        {
            Name = "Неизвестно";
            Age = 18;
            Group = "Не определена";
            AverageGrade = 0.0;
            totalStudents++;
        }
        public Student(string n) : this()
        {
            Name = n;
        }
        public Student(string n, int age) : this(n)
        {
            Age = age;
        }
        public Student(string n, int age, string g, double a) : this(n, age)
        {
            Group = g;
            AverageGrade = a;
        }
        public static int GetTotalStudents()
        {
            return totalStudents;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возвраст: {Age}, Группа: {Group}, Средний балл: {AverageGrade:F2}.");
        }
    }
}
