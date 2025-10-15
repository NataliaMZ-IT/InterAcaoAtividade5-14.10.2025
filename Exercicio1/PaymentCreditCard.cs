using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class PaymentCreditCard : Payment
    {
        public int Parcels;

        public void SetParcels(int Parcels)
        {
            this.Parcels = Parcels;
        }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Payment of ${this.GetValue()} due {this.GetDueDate().ToString("dd/MM/yyyy")}.");
            Console.WriteLine($"Paying {this.Parcels} parcels of ${this.CalculateParcelValue():F2}.");
        }

        public double CalculateParcelValue()
        {
            return this.GetValue() / Parcels;
        }
    }
}
