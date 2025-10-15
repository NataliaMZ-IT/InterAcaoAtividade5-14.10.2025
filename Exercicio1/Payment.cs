using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public abstract class Payment
    {
        private double Value;
        private DateTime DueDate;

        public abstract void ProcessPayment();

        public void SetValue(double value)
        {
            Value = value;
        }
        public double GetValue()
        {
            return this.Value;
        }
        public void SetDueDate(string dueDate)
        {
            DueDate = Convert.ToDateTime(dueDate);
        }
        public DateTime GetDueDate()
        {
            return this.DueDate;
        }
    }
}
