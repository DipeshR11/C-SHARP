using System;

namespace AS1
{
    class Student
    {
        string name;
        string course;
        int age;
        int marks;

        public void SetStudentDetails(string name, string course, int age,int marks)
        {
            this.name = name;
            this.course = course;
            this.age = age;
            this.marks = marks;
        }

        public string GetDetails()
        {
            return "Student Name: " + this.name +
                   "\nStudent Course: " + this.course +
                   "\nStudent Age: " + this.age +
                   "\nStudent Marks: " + this.marks;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.SetStudentDetails("Dipesh", "BSc.CSIT", 20,52);

            Console.WriteLine(s.GetDetails());

            Console.ReadLine();
        }
    }
}