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
            string[] positionlist = { "Кассир", "Официант", "Менеджер", "Бухгалтер", "Директор" };
            double[] salary = { 1400, 1000, 2000, 3000, 5000 };

            Employee em1 = new Employee("Абдурахманов", "Кике");
            Employee em2 = new Employee("Баротов", "Тошиба");
            Employee em3 = new Employee("Тестов", "Тестзаде");

        }
    }
}
