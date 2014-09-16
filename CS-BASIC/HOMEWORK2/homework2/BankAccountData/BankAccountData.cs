using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {

        string firstName = "Anna";
        string middleName = "Marria";
        string lastName = "Peikova";
        
        decimal moneyBalance = 10963.48m;
        
        string bankName = "UNICREDIT";
        string IBAN = "BG32 UBSS 1447 9012 5029 05";
        
        long CC1 = 23456789123504;
        long CC2 = 81341231251235;
        long CC3 = 34124132413413;

        Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}\nCard1 number: {6}\nCard2 number: {7}\nCard3 number: {8}",
            firstName, middleName, lastName, moneyBalance, bankName, IBAN, CC1, CC2, CC3);
        Console.ReadLine();



        }
    }
}
