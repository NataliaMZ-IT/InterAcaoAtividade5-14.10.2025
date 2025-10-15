using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public abstract class Notification
    {
        public virtual void Send(string message) 
        {
            Console.WriteLine($"Sending notification: {message}");
        }
    }
}
