using System;

abstract class Account
{
    private Customer customer;
    private decimal balance;
    private decimal interestRate;

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }
    
    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }
    
    public decimal InterestRate
    {
        get { return interestRate; }
        set { interestRate = value; }
    }

    public virtual decimal CalculateInterest(decimal numberOfmonths)
    {
        return numberOfmonths * this.InterestRate * this.Balance;
    }
}