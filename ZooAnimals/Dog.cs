using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Dog : Animal
    {
        public override void EmitSound()
        {
            Console.WriteLine("Arf arf");
        }
    }
}
