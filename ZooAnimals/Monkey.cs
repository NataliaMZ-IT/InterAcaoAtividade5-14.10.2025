using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    internal class Monkey : Animal
    {
        public override void EmitSound()
        {
            Console.WriteLine("Oo oo aa aa");
        }
    }
}
