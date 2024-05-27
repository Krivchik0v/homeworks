using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNew2
{
    public class City
    {
        public string Name { get; set; }

        private int population;
        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City city, int amount)
        {
            city.Population += amount;
            return city;
        }

        public static City operator -(City city, int amount)
        {
            city.Population -= amount;
            return city;
        }
        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }
        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }
        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }
        public override bool Equals(object obj)
        {
            if (obj is City)
            {
                City other = (City)obj;
                return this.Population == other.Population;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Population: {Population}";
        }
    }
}
