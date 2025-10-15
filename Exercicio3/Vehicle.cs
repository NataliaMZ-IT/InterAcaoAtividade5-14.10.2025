using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public abstract class Vehicle
    {
        public string Manufacturer;
        public string Model;
        public int Year;

        public Vehicle(string manufacturer, string model, int year)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
        }

        public string GetManufacturer()
        {
            return this.Manufacturer;
        }

        public string GetModel()
        {
            return this.Model;
        }

        public int GetYear()
        {
            return this.Year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name of Manufacturer: " + this.Manufacturer);
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Year: " + this.Year);
        }
    }
}
