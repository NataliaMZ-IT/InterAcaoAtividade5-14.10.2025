using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    public abstract class Animal
    {
        private string Name;
        private int Age;

        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }
        public int GetAge()
        {
            return this.Age;
        }

        public abstract void EmitSound();

        public void ShowInfo()
        {
            Console.WriteLine("\nName: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            this.EmitSound();
        }
    }
}
