using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Country
    {
        string name;
        int TotalPopulation=0;
        public City[] cities;
        public Country(string name)
        {
            this.name = name;
            cities = new City[0];
        }

        public void AddCity(Country country,City city)
        {
            Array.Resize(ref country.cities, country.cities.Length + 1);
            country.cities[country.cities.Length - 1] = city;
            country.TotalPopulation += city.Population;
        }

        public void FindAllByPopulation(int min,int max)
        {
            foreach (City city in cities)
            {
                if (city.Population > min)
                {
                    if (city.Population < max)
                    {
                        Console.WriteLine(city);
                    }
                }
            }
        }

    }
}
