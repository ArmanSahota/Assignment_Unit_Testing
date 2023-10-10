using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing
{
    public class Checking : Account
    {
        double _overdraftCharge;

        public Checking(double balance) : base(balance)
        {
            _overdraftCharge = 15;
        }

        public override void Deposit(double amount)
        {
            if(amount > 0)
            {
                _balance += amount;
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (_balance - amount < 0)
                {
                    _balance -= 15;
                    _balance -= amount;
                }
                else
                {
                    _balance -= amount;
                }
            }
        }
            public double Balance
        {
            get { return _balance; }
        }
    }
}
