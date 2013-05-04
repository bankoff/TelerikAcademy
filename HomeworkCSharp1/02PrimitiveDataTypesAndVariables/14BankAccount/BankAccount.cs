/* A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit 
 * card numbers associated with the account. Declare the variables needed to 
 * keep the information for a single bank account using the appropriate data 
 * types and descriptive names.
 */

using System;

class BankAccount
{
    static void Main()
    {
        string account;
        string firstName = "Ivan";
        string middleName = "Iliev";
        string lastName = "Ivanov";
        decimal money = 5000.15m;
        string bankName = "Bulbank";
        string iban = "BG38UNCR96601051876629";
        string bicCode = "UNCRBGSF";
        uint creditCard1 = 100100101;
        uint creditCard2 = 100100102;
        uint creditCard3 = 100100103;
        account = "Name:" + firstName + " " + middleName + " " + lastName + "\n"
            + "Balance:" + money + " Euro" + "\n"
            + "Bank:" + bankName + "\n"
            + "IBAN " + iban + "\n"
            + "BIC code " + bicCode + "\n"
            + "Numbers of credit cards: \n"
            + creditCard1 + "\n"
            + creditCard2 + "\n"
            + creditCard3;
        Console.WriteLine(new string('-', 30));
        Console.WriteLine(account);
        Console.WriteLine(new string('-', 30));
    }
}