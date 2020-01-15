//Author: Lucyca Muruket
//Id number: 111 55
//Polymorphic Banking program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    //Derived class of savings account from the base class Acccount
    public class SavingsAccount : PolymorphicBanking
    {
        //decimal instance variable indicating the interest rate 
        private decimal interestrate;

        //savings account constructor
        public SavingsAccount(decimal balance, decimal interestRate): base(balance)
        {
            //recieves the initial balance 
            InterestRate = interestRate;
        }

        //property of Interest rate that reads and sets the interest rate
        public decimal InterestRate
        {
            //get accessor
            get
            {
                return interestrate;
            }//end of get get accessor

            //the set accessor
            set
            {
                //the value msut be greater than 0, if not a message is displayed
                if (value > 0)
                    interestrate = value;

                else
                    Console.WriteLine("The interest rate must be greater than zero");
            }
        }

        //Calculate the amount of interest
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }//end of method Calculate interest

    }//end of savings account class
}//end of namespace
