using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNew2
{
    internal class Employee
    {

        public string Name { get; set; }
        public string Position { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public static Employee operator +(Employee employee, decimal amount)
        {
            employee.Salary += amount;
            return employee;
        }
        public static Employee operator -(Employee employee, decimal amount)
        {
            employee.Salary -= amount;
            return employee;
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Salary == employee2.Salary;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }
        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return this.Salary == other.Salary;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, Salary: {Salary}";
        }
    }
}

