using System;

abstract class Customer
{
    private string name;
    private string iDNumber;

    protected string Name 
    {
        get { return name; }
        set { name = value; }
    }
    
    protected string IDNumber 
    {
        get { return iDNumber; }
        set { iDNumber = value; }
    }

    protected Customer(string name, string iDNumber)
    {
        this.Name = name;
        this.IDNumber = iDNumber;
    }
}