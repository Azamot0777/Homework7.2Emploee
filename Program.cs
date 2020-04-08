using System;

namespace Homework7_2emplo
{
    class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int experience { get; set; }
        public string position { get; set; }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
