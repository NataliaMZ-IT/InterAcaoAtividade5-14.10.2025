using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class PaymentBoleto : Payment
    {
        public DateTime PaidDate;

        public void SetPaidDate()
        {
            this.PaidDate = DateTime.Now.Date;
        }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Payment of ${this.GetValue()} due {this.GetDueDate().ToString("dd/MM/yyyy")}.");
            Console.WriteLine($"Sucessfully paid on the {this.PaidDate.ToString("dd/MM/yyyy")} via boleto.");
        }
    }
}
