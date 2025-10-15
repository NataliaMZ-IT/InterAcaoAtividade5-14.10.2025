using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class BankAccount
    {
        private double Balance;
        private string Holder;

        public double GetBalance()
        {
            return this.Balance;
        }
        public void SetHolder(string holder)
        {
            this.Holder = holder;
        }
        public string GetHolder()
        {
            return this.Holder;
        }

        public void DepositBalance(double value)
        {
            this.Balance += value;
        }
        public void WithdrawBalance(double value)
        {
            if (value >= this.Balance)
            {
                Console.WriteLine("You don't have enough in your balance to withdraw that much!");
            }
            else
            {
                this.Balance -= value;
                Console.WriteLine($"${value:F2} sucessfully withdrawn from your balance.");
            }
        }
    }
}
