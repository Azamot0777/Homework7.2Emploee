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
        public static double CountNalog(double zarp)
        {
            double nalog = zarp * 0.15;
            return Math.Round(nalog);
        }
        public double CountZarplata(string[] positionList, double[] salary)
        {
            double zarp = 0;
            int i, k = positionList.Length;
            for (i = 0; i < k; i++)
            {
                if (this.position == positionList[i])
                {
                    zarp += salary[i] + (this.experience / 10) * 100 + 50;
                    break;
                }
            }
            if (zarp == 0)
            {
                Console.WriteLine("Нет этой позиции");
            }
            return Math.Round(zarp, 4);

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string[] positionList = { "Кассир", "Официант", "Менеджер", "Бухгалтер", "Директор" };
            double[] salary = { 1400, 1000, 2000, 3000, 5000 };

            Employee em1 = new Employee("Абдурахманов", "Кике");
            Employee em2 = new Employee("Баротов", "Тошиба");
            Employee em3 = new Employee("Тестов", "Тестзаде");

            double zarp1, zarp2, zarp3;
            double nalog1, nalog2, nalog3;

            em1.position = "Кассир";
            em2.position = "Менеджер";
            em3.position = "Директор";

            em1.experience = 3;
            em2.experience = 4;
            em3.experience = 7;

            zarp1 = em1.CountZarplata(positionList, salary);
            zarp2 = em2.CountZarplata(positionList, salary);
            zarp3 = em3.CountZarplata(positionList, salary);

            nalog1 = Employee.CountNalog(zarp1);
            nalog2 = Employee.CountNalog(zarp2);
            nalog3 = Employee.CountNalog(zarp3);


            System.Console.WriteLine($"Фамалия:{em1.surname} Имя :{em1.name} Должность : {em1.position} Запр:{zarp1} Налог: {nalog1}");
            System.Console.WriteLine($"Фамалия:{em2.surname} Имя : {em2.name} Должность : {em2.position} Запр: {zarp2} Налог: {nalog2}");
            System.Console.WriteLine($"Фамалия:{em3.surname} Имя : {em3.name} Должность : {em3.position} Запр:{zarp3} Налог:{nalog3}");



        }
    }
}
