using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class PushNotification : Notification
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Push notification sent!");
        }
    }
}
