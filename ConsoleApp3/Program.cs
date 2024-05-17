using ConsoleApp3;
using System;
using System.Data;

class Program
    {

    static void Main(string[] args)
    {

        /*try
        {
            ForeignPassport passport = new ForeignPassport("123456789", "тест тест тест", new DateTime(2010, 5, 5));
            Console.WriteLine("Паспорт создан успешно!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Ошибка инициализации паспорта: {e.Message}");
        }*/

        Console.WriteLine("Введите номер домашнего задания (от 1 до 6):");
        int assignmentNumber = int.Parse(Console.ReadLine());


      

        switch (assignmentNumber)
        {
            case 1:
                Console.WriteLine("Я не смог сделать это");
                break;
            case 2:
                Task2();
                break;
            case 3:
                Console.WriteLine("Я создал класс в отдельном файле как вы говориле ранее, я код на проверку паспорта на действительность закоментировал в Main");
                break;
            case 4:
                Task4(); //Я не знаю можно ли это делать, но я не знал как сделать это задание так что, что бы его сделать я посмотрел в интернете возможные способы как можно проверить булевые выражение которые в строке, у меня была идея разделить строку на символы и находить логический символ а также числа которые в строке и проверять как то, но я не понял как, насколько я знаю это можно сделать как то через регулярные выражения но  я н езнаю их в с#
                break;
            default:
                Console.WriteLine("Неверное задание ");
                break;
        }
    }

    static void Task2()
    {
        string[] numbers = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        Console.WriteLine("Введите число словами от нуля до девяи: ");
        string word = Console.ReadLine().ToLower();
        int number = Array.IndexOf(numbers, word);
        if (number != -1)
        {
            Console.WriteLine($"Соответствующее число: {number}");
        }
        else
        {
            Console.WriteLine("Неверное слово!");
        }
    }

    static void Task4()
    {
        Console.WriteLine("Введите логическое выражение (например, 3>2 или 7<=3):");
        string input = Console.ReadLine();
        try
        {
            bool result = Convert.ToBoolean(new DataTable().Compute(input, null));
            Console.WriteLine($"Результат: {result}");
        }
        catch
        {
            Console.WriteLine("Ошибка: Некорректное логическое выражение");
        }
    }


}
