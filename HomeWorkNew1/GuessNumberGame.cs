using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Game
    {
        private int _min;
        private int _max;
        private int _number;
        public Game(int min, int max)
        {
            _min = min;
            _max = max;
        }
        public void Start()
        {
            _number = new Random().Next(_min, _max + 1);
            Console.WriteLine($"Угадайте число от {_min} до {_max}:");
            int guess = int.Parse(Console.ReadLine());
            while (guess != _number)
            {
                if (guess < _number)
                    Console.WriteLine("Угаданное число меньше загаданого");
                else
                    Console.WriteLine("Угаданное число больше загаданного");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вы угадали число!");
        }
    }
}
