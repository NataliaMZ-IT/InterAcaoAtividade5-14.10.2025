using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerTypes
{
    public class WorkerPJ : Worker
    {
        private int HoursWorked;
        private double HourlyWage;

        public override double CalculateFinalSalary()
        {
            return this.HoursWorked * this.HourlyWage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Hours Worked: " + this.HoursWorked);
            Console.WriteLine("Hourly Wage: " + this.HourlyWage);
            Console.WriteLine("Total Salary: " + this.CalculateFinalSalary());
        }

        public void SetHours(int hoursWorked)
        {
            this.HoursWorked = hoursWorked;
        }

        public void SetHourlyWage(double hourlyWage)
        {
            this.HourlyWage = hourlyWage;
        }
    }
}
