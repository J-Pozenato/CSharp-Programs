using System;

namespace ProgChallenge{


    class SavingsAcct : Account
    {
            // SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.025m, 1000.0m);
            private decimal _interest;
            public SavingsAcct(string name, string surname, decimal interest, decimal balance)
                                : base (name, surname, balance)  //Inheritance from account
            {
                _interest = interest;
            }

            public decimal Interest // savings account has interest
            {
                get => _interest;
                set => _interest = value;
            }

            private int withdCount = 0;  //savings account has a limit of free withdrawals
            public override void Withdraw(decimal withd)
            {
                withdCount++;
                if (withd > Balance)
                {
                    Console.WriteLine("Attempt to overdraw denied");   // You can't go to negative balance in a savings account
                }
                else if (withdCount > 3)
                {
                    Balance -= withd + 2;
                    Console.WriteLine("more than 3 withdrawals - extra charge");
                } 
                else
                {
                    Balance -= withd;
                }
            }

            public void ApplyInterest()
            {
                Balance *= 1 + Interest; // apllies the interest to the balance
            }
            
            
                            
                                
    }
}