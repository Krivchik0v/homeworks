using HomeworkNew2;
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер домашнего задания (от 1 до 4):");
            int assignmentNumber = int.Parse(Console.ReadLine());

            switch (assignmentNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Console.WriteLine("Я не смог сделать это задание");
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                default:
                    Console.WriteLine("Неверный номер задания");
                    break;
            }
        }

        static void Task1()
        {
            Employee employee1 = new Employee("Alexander", "Developer", 5000);
            Employee employee2 = new Employee("Pierre", "Manager", 6000);
            employee1 = employee1 + 1000;
            Console.WriteLine("Updated employee1: " + employee1);
            employee2 = employee2 - 500;
            Console.WriteLine("Updated employee2: " + employee2);
            Console.WriteLine("Are salaries equal?" + (employee1 == employee2));
            Console.WriteLine("Is employee1 salary less than employee2? " + (employee1 < employee2));
            Console.WriteLine("Is employee2 salary greater than employee1? " + (employee2 > employee1));
            Console.WriteLine("Are salaries unequal?" + (employee1 != employee2));
            Console.WriteLine("Are salaries equal (using Equals) " + employee1.Equals(employee2));
        }
        static void Task3()
        {
            City city1 = new City("New York", 10000000);
            City city2 = new City("Los Angeles", 4000000);
            city1 = city1 + 100000;
            Console.WriteLine("Updated city1: " + city1);
            city2 = city2 - 50000;
            Console.WriteLine("Updated city2: " + city2);
            Console.WriteLine("Are populations equal? " + (city1 == city2));
            Console.WriteLine("Is city1 population less than city2?" + (city1 < city2));
            Console.WriteLine("Is city2 population greater than city1? " + (city2 > city1));
            Console.WriteLine("Are populations unequal?" + (city1 != city2));
            Console.WriteLine("Are populations equal (using Equals)? " + city1.Equals(city2));
        }
        static void Task4()
        {
            CreditCard card1 = new CreditCard("352352365436", "123", 1000);
            CreditCard card2 = new CreditCard("542352525234", "456", 2000);

            card1 = card1 + 500;
            Console.WriteLine("Updated card1: " + card1);
            card2 = card2 - 300;
            Console.WriteLine("Updated card2: " + card2);
            Console.WriteLine("Are CVC codes equal? " + (card1 == card2));
            Console.WriteLine("Is card1 balance less than card2? " + (card1 < card2));
            Console.WriteLine("Is card2 balance greater than card1? " + (card2 > card1));
            Console.WriteLine("Are CVC codes unequal? " + (card1 != card2));
            Console.WriteLine("Are CVC codes equal (using Equals)? " + card1.Equals(card2));

        }
    }
}
