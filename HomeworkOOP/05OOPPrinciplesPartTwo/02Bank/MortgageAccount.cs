using System;

class MortgageAccount : Account, IDepositable
{
    public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public override decimal CalculateInterest(decimal numberOfmonths)
    {

        if ((numberOfmonths <= 6 && this.Customer is Individual))
        {
            return 0;
        }
        else if ((numberOfmonths > 6 && this.Customer is Individual))
        {
            return (numberOfmonths - 6) * this.InterestRate * this.Balance;
        }
        else if (numberOfmonths <= 12 && this.Customer is Company)
        {
            return (numberOfmonths * this.InterestRate * this.Balance) / 2;
        }
        else
        {
            return (numberOfmonths - 12) * this.InterestRate * this.Balance;
        }
    }

    public decimal DepositMoney(decimal amount)
    {
        return this.Balance = this.Balance + amount;
    }
}