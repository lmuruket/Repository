//Author: Lucyca Muruket
//Id number: 111 55
//Inheritence hierarchy for a bank to use

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    //parent class of account
    public class PolymorphicBanking
    {
        //instance variable of balance
        private decimal balance;

        //Constructor that recieves initial balance and uses it to initialize the instance variable
        public PolymorphicBanking(decimal balance)
        {
            Balance = balance;
        }

        //the property of Balance validates the initial balance
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                //ensures that the initial balance is greater than or equal to 0.0
                if (value >= 0.0M)
                    balance = value;
                //trows an exception when the initial balance is less than 0.0
                else
                    throw new Exception("Balance cannot be negative");
            }//end of set accessor
        }//end of the property

        //public method credit
        public virtual void Credit(decimal amount)
        {
            //amount should be greater than zero
            if (amount > 0)
                Balance += amount; //adds the  amount to current balance
            
            //throws an exception when the amount is less than 0
            else
                throw new Exception("The amount credited must be greater than zero");
        }

        //Account's debit method is defined so that it returns a bool indicating that a whether money was withdrawn
        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                //display message when the amount exceeds the balance
                Console.WriteLine("Debit amount exceeded account balance.");
                OK = false;
            }
            return OK;
        
        }//end of method debit
    }//end of class
}//end of namespace
