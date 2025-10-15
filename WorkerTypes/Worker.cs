using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerTypes
{
    public abstract class Worker
    {
        private string Name;
        private double baseSalary;

        public abstract double CalculateFinalSalary();

        public virtual void ShowInfo()
        {
            Console.WriteLine("\nName: " + this.Name);
            Console.WriteLine("Base Salary: " + this.baseSalary);
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetBaseSalary(double baseSalary)
        {
            this.baseSalary = baseSalary;
        }
        public double GetBaseSalary()
        {
            return this.baseSalary;
        }
    }
}
