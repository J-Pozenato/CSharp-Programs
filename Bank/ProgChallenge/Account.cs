using System;

namespace ProgChallenge
{



    class Account
    {
        public Account(string name, string surname, decimal balance=0.0m) // if no inital balance is set the Balance goes to 0
        {
            AccountOwner = name + " " + surname;
            Balance = balance;
        }

        public string AccountOwner // Saving the name of the account owner
        {
            get; set;
        }
        public decimal Balance      // saving the balance
        {
            get; set;
        }

        public void Deposit(decimal depo)
        {
            Balance += depo;                //function called for deposits
        }

        public virtual void Withdraw(decimal withd) //function called for withdraw, it has to be virtual
                                                    // because there are different types of withdraw in each account type
        {
            Balance -= withd;               
        }
    }
}