using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Web site: ");
            string companySite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Manager phone: ");
            string managerPhoneNumber = Console.ReadLine();
            bool chekFaxExist = true;
            if (companyFax == String.Empty) { chekFaxExist = false; }
            Console.WriteLine("{0}\nAddress: {1}\ntel. {2}\nFax: {3}"+
            "\nWebsite: {4}\nManager: {5} {6} ( age: {7} tel. {8})", 
            companyName, companyAddress, companyPhoneNumber,chekFaxExist? companyFax:"(No fax)", companySite, 
             managerName, managerLastName,  managerAge,managerPhoneNumber);
               
            Console.ReadLine();
        }
    }
}
