using System;

namespace HomeworkAssignments
{

    class Shop //6 задание
    {
        private string name;
        private string address;
        private string profileDescription;
        private string phoneNumber;
        private string email;
        public void InputData()
        {
            Console.Write("Введите название магазина: ");
            name = Console.ReadLine();
            Console.Write("Введите адрес магазина: ");
            address = Console.ReadLine();
            Console.Write("Введите описание профиля магазина: ");
            profileDescription = Console.ReadLine();
            Console.Write("Введите контактный телефон магазина: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Введите контактный e-mail магазина: ");
            email = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine("Название магазина: " + name);
            Console.WriteLine("Адрес магазина: " + address);
            Console.WriteLine("Описание профиля магазина: " + profileDescription);
            Console.WriteLine("Контактный телефон магазина: " +phoneNumber);
            Console.WriteLine("Контактный e-mail магазина: "+ email);
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string newAddress)
        {
            address = newAddress;
        }
        public string GetProfileDescription()
        {
            return profileDescription;
        }

        public void SetProfileDescription(string newProfileDescription)
        {
            profileDescription = newProfileDescription;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string newPhoneNumber)
        {
            phoneNumber = newPhoneNumber;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string newEmail)
        {
            email = newEmail;
        }
    }

    class Journal //5 задание
    {
        private string title;
        private int foundationYear;
        private string description;
        private string phoneNumber;
        private string email;

        public void InputData()
        {
            Console.Write("Введите название журнала: ");
            title = Console.ReadLine();
            Console.Write("Введите год основания журнала: ");
            foundationYear = int.Parse(Console.ReadLine());
            Console.Write("Введите описание журнала: ");
            description = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Введите контактный e-mail: ");
            email = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("Название журнала: " + title);
            Console.WriteLine("Год основания журнала: " + foundationYear);
            Console.WriteLine("Описание журнала: " + description);
            Console.WriteLine("Контактный телефон: " + phoneNumber);
            Console.WriteLine("Контактный e-mail: " + email);
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }

        public int GetFoundationYear()
        {
            return foundationYear;
        }

        public void SetFoundationYear(int newFoundationYear)
        {
            foundationYear = newFoundationYear;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string newDescription)
        {
            description = newDescription;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string newPhoneNumber)
        {
            phoneNumber = newPhoneNumber;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string newEmail)
        {
            email = newEmail;
        }
    }

   


class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер домашнего задания (от 1 до 6):");
            int assignmentNumber = int.Parse(Console.ReadLine());


            switch (assignmentNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Console.WriteLine("Я не смог сделать это задание");
                    break;
                case 4:
                    Console.WriteLine("Я не смог сделать это задание");
                    break;
                case 5:
                    Console.WriteLine("Я не совсем понял как сделать 4,5,6 задания, я реализовал класс из 5 задания выше");
                    break;
                case 6:
                    Console.WriteLine("Я не совсем понял как сделать 4,5,6 задания, я реализовал класс из 6 задания выше");
                    break;
                default:
                    Console.WriteLine("Неверный номер задания");
                    break;
            }

        }

        static void Task1()
        {
            Console.Write("Введите длину стороны квадрата:");
            int sideLength = int.Parse(Console.ReadLine());
            Console.Write("Введите символ для заполнения квадрата:");
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void Task2()
        {
            
            Console.Write("Введите число:");
            string numberString = int.Parse(Console.ReadLine()).ToString();
            int length = numberString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (numberString[i] != numberString[length - 1 - i])
                {
                    Console.Write("False");
                    return;
                }
            }

            
            Console.Write("true");
        }


    }

}
