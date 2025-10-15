using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerTypes
{
    public class WorkerCLT : Worker
    {
        private double Bonus;

        public override double CalculateFinalSalary()
        {
            return this.GetBaseSalary() + Bonus;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Bonus: " + this.Bonus);
            Console.WriteLine("Total Salary: " + this.CalculateFinalSalary());
        }

        public void SetBonus(double bonus)
        {
            this.Bonus = bonus;
        }
    }
}
