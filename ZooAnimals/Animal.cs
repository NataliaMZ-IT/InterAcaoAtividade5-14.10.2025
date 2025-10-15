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

        public override string ToString()
        {
            return $"Name: {this.Name}\nAge: {this.Age}";
        }
    }
}
