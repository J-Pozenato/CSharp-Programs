using System;

namespace ProgChallenge
{

    class CheckingAcct : Account 
    {
            // CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);
        public CheckingAcct(string name, string surname, decimal balance)
                                : base (name, surname, balance) // Inheritance from account
        {
            
        }

        public override void Withdraw(decimal withd)
        {
            if(withd > Balance)
            {
                Balance -= withd + 35; //checking account can go to negative numbers and there is a penalty for doing so
            }
            else
            {
                Balance -= withd;
            }
        }
    }
}