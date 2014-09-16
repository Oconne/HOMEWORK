// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
// 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account 
// using the appropriate data types and descriptive names.

namespace BankAccountData
{
    using System;

    class BankAccount
    {
        static void Main()
        {
            string firstName = "Bongo";
            string middleName = "Mongo";
            string lastName = "Dongo";
            decimal amount = 3000.00M;
            string bankName = "UCB";
            string iban = "BG80BNBG96611020345678";
            string firstCardNumber = "5105105105105100";
            string secondCardNumber = "4111111111111111";
            string thirthCardNumber = "378282246310005";

            Console.WriteLine("Bank Account:");
            Console.WriteLine("FirstName {0}", firstName);
            Console.WriteLine("MiddleName {0}", middleName);
            Console.WriteLine("LastName {0}", lastName);
            Console.WriteLine("Amount {0}", amount);
            Console.WriteLine("BankName {0}", bankName);
            Console.WriteLine("IBAN {0}", iban);
            Console.WriteLine("FirstCardNumber {0}", firstCardNumber);
            Console.WriteLine("SecondCardNumber {0}", secondCardNumber);
            Console.WriteLine("ThirthCardNumber {0}", thirthCardNumber);
        }
    }
}
