using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {

            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i].name = "sana " + i.ToString();
                students[i].address = "vizag ";
                students[i].rollNumber = 7;
                students[i].className = " PP1";
                students[i].dateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00");
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].name + ",");
                Console.Write(students[i].address + ",");
                Console.Write(students[i].rollNumber + ",");
                Console.Write(students[i].className + ",");
                Console.Write(students[i].dateOfBirth);
                Console.WriteLine("------------------------");
               
            }
            Console.ReadLine();
        }
    }

    struct Student
    {
        public string name;
        public string address;
        public int rollNumber;
        public string className;
        public DateTime dateOfBirth;
    }
   
}
