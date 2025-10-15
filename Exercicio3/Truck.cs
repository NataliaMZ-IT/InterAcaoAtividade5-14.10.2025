using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Truck : Vehicle
    {
        public double WeightCapacity;

        public Truck(string manufacturer, string model, int year, double weightCapacity) : base(manufacturer, model, year)
        {
            this.WeightCapacity = weightCapacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Vehicle Type: Truck");
            base.ShowInfo();
            Console.WriteLine("Weight Capacity: " + this.WeightCapacity + "Kg");
        }
    }
}
