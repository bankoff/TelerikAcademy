/* A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. Write a 
 * program that reads the information about a company and its manager and 
 * prints them on the console.
 */

using System;

class CompanyAndItsManager
{
    static void Main()
    {
        Console.WriteLine("Input name of the company and then press Enter");
        Console.Write("Company: ");
        string company = Console.ReadLine();
        Console.WriteLine("Input address of the company and then press Enter");
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.WriteLine("Input company phone number and then press Enter");
        Console.Write("Company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("Input company FAX number and then press Enter");
        Console.Write("FAX ");
        string companyFax = Console.ReadLine();
        Console.WriteLine("Input web site of the company and then press Enter");
        Console.Write("web site: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Input manager first name and then press Enter");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Input manager last name and then press Enter");
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Input how old is manager and then press Enter");
        Console.Write("Age: ");
        string age = Console.ReadLine();
        Console.WriteLine("Input manager phone number and then press Enter");
        Console.Write("Manager phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("Company: {0} \nAddress: {1} \nPhone number: {2}     FAX: {3} \nweb site: {4}",
            company, address, companyPhone, companyFax, webSite);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Manager: {0} {1} - {2} age \nPhone number: {3}",
            firstName, lastName, age, managerPhone);
        Console.WriteLine(new string('=', 50));
    }
}