using System;

class Individual : Customer
{
    public Individual(string name, string iDNumber)
        :base(name,iDNumber)
    {
        if (name != null && name != String.Empty && name.Length > 2)
        {
            this.Name = name;
        }
        else
        {
            throw new ArgumentOutOfRangeException("The name should be at least 3 symbols!");
        }

        if (iDNumber != null && iDNumber != String.Empty && iDNumber.Length == 10)
        {
            this.IDNumber = iDNumber;
        }
        else
        {
            throw new ArgumentOutOfRangeException("The identification number should be 10 symbols!");
        }
    }
}