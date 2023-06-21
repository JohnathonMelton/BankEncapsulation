using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"A deposit of {amount, 0:c} has been added to your account.");
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}
