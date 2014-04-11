// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

namespace EmployeeData
{
    using System;

    class Employee
    {
        static void Main()
        {
            string firstName = "Bango";
            string lastName = "Tango";
            byte age = 33;
            char gender = 'm';
            ulong personalId = 8306112507;
            uint uniqueEmplId = 27560555;

            Console.WriteLine("Employee");
            Console.WriteLine("First name {0}", firstName);
            Console.WriteLine("Last name {0}", lastName);
            Console.WriteLine("Age {0}", age);
            Console.WriteLine("Gender {0}", gender);
            Console.WriteLine("Personal ID number {0}", personalId);
            Console.WriteLine("Unique employee number {0}", uniqueEmplId);
            Console.ReadLine();
        }
    }
}
