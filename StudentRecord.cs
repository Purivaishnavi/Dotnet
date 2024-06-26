using System;
namespace Record

{
    class Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Students:");
            int n = Convert.ToInt32(Console.ReadLine());

            Members[] m = new Members[n];
            for (int i = 0; i < n; i++)
            {
                m[i] = new Members();
                Console.WriteLine("Enter the details of student " + (i + 1) + ":");
                m[i].AddMembers();
            }

            Console.WriteLine("Roll\tSem\tName\tBranch\tCollege");
            for (int i = 0; i < n; i++)
            {
                m[i].Display();
            }
        }
    }

    class Members
    {
        int roll, sem;
        string name, branch, college;

        public void AddMembers()
        {
            Console.WriteLine("Enter Roll:");
            roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Semester:");
            sem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Branch:");
            branch = Console.ReadLine();

            Console.WriteLine("Enter College:");
            college = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine(roll + "\t" + sem + "\t" + name + "\t" + branch + "\t" + college);
        }
    }
}   