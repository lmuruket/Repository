//Author: Lucyca Muruket
//Id number: 111 55
//Polymorphic banking program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    //the account test class
    public class PolymorphicBankingTest
    {
        //the main method
        public static void Main()
        {
            //Display a welcoming message
            Console.WriteLine("WELCOME TO THIS BANKING SYSTEM APPLICATION");
            Console.WriteLine("---------------------------------------------------------------------");
            //give space
            Console.WriteLine();

            decimal Credit, Debit;

            //initialize the objects for savings account
            decimal TotalCredit = 00.00M;
            SavingsAccount savingsaccount = new SavingsAccount(1000.00M, 0.10M);

            Console.WriteLine("The customer's beginning balance is {0:C}", savingsaccount.Balance);

            Console.Write("Enter an amount to Deposit into savings account: $");
            Credit= Convert.ToDecimal(Console.ReadLine());
            savingsaccount.Credit(Credit);

            //invokes the calculate interest method
            TotalCredit = savingsaccount.CalculateInterest();
            Console.WriteLine("Interest of {0:C}", TotalCredit);

            //pass the returned interest amount to the object's credit 
            savingsaccount.Credit(TotalCredit);
            //an amount is withdrawn from the account and a reasonable fee is charged for the transaction made.

            Console.Write("Enter an amount to Withdraw from savings account: $");
            Debit = Convert.ToDecimal(Console.ReadLine());
            savingsaccount.Debit(Debit);

            Console.WriteLine("The new balance is of savings account is {0:C}", savingsaccount.Balance);
            Console.WriteLine("---------------------------------------------------------------------");

            //initializes the object for checking account
            //Checking account charges fee for every transactions a customer makes
            CheckingAccount checkingaccount = new CheckingAccount(1000.00M, 2.50M);
            Console.WriteLine("The customer's initial balance is {0:C}", checkingaccount.Balance);
            
            //an amount is deposited to the account and a fee is charged for the transaction made
            Console.Write("Enter an amount to Deposit into checking account: $");
            Credit = Convert.ToDecimal(Console.ReadLine());
            checkingaccount.Credit(Credit);
            Console.WriteLine("The customer's balance after the amount has been deposited with the fee charged is {0:C}", checkingaccount.Balance);
            
            //an amount is withdrawn from the account and a reasonable fee is charged for the transaction made.
            Console.Write("Enter an amount to Withdraw from checking balance: $");
            Debit = Convert.ToDecimal(Console.ReadLine());
            checkingaccount.Debit(Debit);

            //After all the customer's transactions the, the ending balance is displayed 
            Console.WriteLine("The customer's balance after all the transactions done stands to be {0:C}", checkingaccount.Balance);

            Console.WriteLine("---------------------------------------------------------------------");

            //array of Account references to SavingsAccount and CheckingAccount objects.
            PolymorphicBanking [] account = new PolymorphicBanking[2];

            account[0] = savingsaccount;
            account[1] = checkingaccount;

            foreach (PolymorphicBanking accounts in account)
            {
                Console.WriteLine(accounts);//Display accounts
                Console.WriteLine("Account Balance: {0}\n", accounts.Balance);//Didplay Account Balance

            }

            //Range
            for (int i = 0; i < account.Length; i++)
               
                //Display account type
               Console.WriteLine("Account {0} is {1}\n", i, account[i].GetType());

            Console.WriteLine("====================================================");
         
            Console.WriteLine("THANK YOU VERY MUCH FOR USING THIS SYSTEM APPLICATION");
            Console.WriteLine("HOPE YOU CHOOSE THIS SYSTEM APPLICATION FOR YOUR NEXT TRANSACTIONS");

            Console.ReadKey();//exit the program

        } // end of main mehod
    } //end of the 
}//end namespace
