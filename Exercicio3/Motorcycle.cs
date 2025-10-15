using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Motorcycle : Vehicle
    {
        public int Seats;

        public Motorcycle(string manufacturer, string model, int year, int seats) : base(manufacturer, model, year)
        {
            this.Seats = seats;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Vehicle Type: Motorcycle");
            base.ShowInfo();
            Console.WriteLine("Number of Seats: " + this.Seats);
        }
    }
}
