using System;

class LoanAccount : Account, IDepositable
{
    public LoanAccount(Customer customer, decimal balance, decimal interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public override decimal CalculateInterest(decimal numberOfmonths)
    {
        if ((this.Customer is Individual) && (numberOfmonths > 3))
        {
            return (numberOfmonths - 3) * this.InterestRate * this.Balance;
        }
        else if ((this.Customer is Company) && (numberOfmonths > 2))
        {
            return (numberOfmonths - 2) * this.InterestRate * this.Balance;
        }
        else
        {
            return 0;
        }

    }

    public decimal DepositMoney(decimal amount)
    {
        return this.Balance = this.Balance + amount;
    }
}