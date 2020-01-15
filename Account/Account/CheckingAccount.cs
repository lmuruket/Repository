//Author: Lucyca Muruket
//Id number: 111 55
//Polymorphic banking program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    //Derived class of checking account from base class Account
    public class CheckingAccount : PolymorphicBanking
    {
        //instance variable of fee charged 
        private decimal feecharged;
        
        //the constructor recieves the initial balance and the indicating fee
        public CheckingAccount(decimal balance, decimal fee): base (balance)
        {
            FeeCharged = fee;
        }

        public decimal FeeCharged
        {
            get
            {
                return feecharged;
            }
            set
            {
                if (value > 0)
                    feecharged = value;
                else
                    throw new Exception("Fee charged cannot be less than zero");
            }
        }

        //credit method is redefinned and fee is subtracted from the account balance
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= FeeCharged;
        }

        //debit method is redefinned and the fee is subtracted from the account balance
        public override bool Debit(decimal amount)
        {
            //debit method is defined so that true/false could be returned indicating whether money was withdrawn
            if (base.Debit(amount))
            {
                Balance -= FeeCharged;
                return true;
            }
            return false;
        }//end of redefined debit method 
    }//end of savings account class
}//end of namespaceS
