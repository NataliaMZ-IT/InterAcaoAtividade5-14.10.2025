using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Car : Vehicle
    {
        public int Doors;

        public Car(string manufacturer, string model, int year, int doors) : base(manufacturer, model, year)
        {
            this.Doors = doors;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Vehicle Type: Car");
            base.ShowInfo();
            Console.WriteLine("Number of Doors: " + this.Doors);
        }
    }
}
