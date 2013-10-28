//02.A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with 
//draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as 
//follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held 
//by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, 
//base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

class Application
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        DepositAccount depAccountInd = new DepositAccount(new Individual("Boyko Draganov", "9090909090"), 230m, 0.003m);
        DepositAccount depAccountComp = new DepositAccount(new Company("Barista", "999999999"), 13000m, 0.006m);

        MortgageAccount mortAccountInd = new MortgageAccount(new Individual("Georgi Dimitrov", "9090909190"), 2300m, 0.005m);
        MortgageAccount mortAccountComp = new MortgageAccount(new Company("Sky", "999999999"), 35000m, 0.008m);

        LoanAccount loanAccountInd = new LoanAccount(new Individual("Hani Kovachev", "9090909190"), 2300m, 0.005m);
        LoanAccount loanAccountComp = new LoanAccount(new Company("Scraper BG", "999999999"), 5000m, 0.002m);

        List<Account> accounts = new List<Account>(){depAccountInd, depAccountComp, mortAccountInd, mortAccountComp,
        loanAccountInd, loanAccountComp};


        foreach (var acc in accounts)
        {
            Console.WriteLine("I am {0}, I am owned by {1}, my current balance is \n{2} and the interest rate for {3} months is: {4:F2}", acc.GetType(),
                acc.Customer.GetType(), acc.Balance, 3, acc.CalculateInterest(3));
            Console.WriteLine(new string('-', 50));
        }
        depAccountInd.DepositMoney(1000);
        depAccountInd.WithdrawMoney(130);

        Console.WriteLine("Deposit Account owned by Individual:\nMy current balance is:{0}, and my interest for 2 months is: {1:F2}",
        depAccountInd.Balance, depAccountInd.CalculateInterest(2));
    }
}