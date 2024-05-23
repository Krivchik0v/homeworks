
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер домашнего задания (от 1 до 6):");
        int assignmentNumber = int.Parse(Console.ReadLine());
        switch (assignmentNumber)
        {
            case 1:

                int count = 0;   
                Console.WriteLine("Введите тип: (odd, even, prime, fibonacci) ");
                string type = Console.ReadLine();
                Console.WriteLine("Введите количество сгенерированных чисел: ");
                int.TryParse(Console.ReadLine(), out count);
                Task1(type, count);
                break;
            case 2:
                Console.WriteLine("Выберите тип фигуры: (triangle, rectangle, square) ");
                Task2(Console.ReadLine());
                break;
            case 3:
                Task3();
                break;
            case 4:
                Console.WriteLine("я не смог это сделать");
                break;
            default:
                Console.WriteLine("Неверное задание ");
                break;
        }
    }
    static void Task1(string type, int count)
    {
        int[] numbers;
        switch (type.ToLower())
        {
            case "even":
                numbers = EvenNumbers.EvenNumberGenerator.Generate(count);
                break;
            case "odd":
                numbers = OddNumbers.OddNumberGenerator.Generate(count);
                break;
            case "prime":
                numbers = PrimeNumbers.PrimeNumberGenerator.Generate(count);
                break;
            case "fibonacci":
                numbers = FibonacciNumbers.FibonacciNumbersGenerator.Generate(count);
                break;
            default:
                throw new ArgumentException("Неверный тип");
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
    static void Task2(string shapeType)
    {
        IShape shape;
        switch (shapeType.ToLower())
        {
            case "triangle":
                shape = new Shapes.Triangle();
                break;
            case "rectangle":
                shape = new Shapes.Rectangle();
                break;
            case "square":
                shape = new Shapes.Square();
                break;
            default:
                throw new ArgumentException("Неверный тип фигуры");
        }

        Console.Write("Введите размер фигуры: ");
        int size = int.Parse(Console.ReadLine());

        shape.Draw(size);
    }

    static void Task3()
    {
        Console.Write("Введите минимальное число: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальное число: ");
        int max = int.Parse(Console.ReadLine());
        GuessTheNumber.Game game = new GuessTheNumber.Game(min, max);
        game.Start();
    }

}