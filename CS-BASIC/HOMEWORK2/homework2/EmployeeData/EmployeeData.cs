using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender (m/f): ");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter your ID number: ");
            long id = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter your unique employee number: ");
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            if (gender == 'm')
            {
                Console.Write(" First Name: " +firstName + "\n Last name: " + lastName + "\n Age: "+ age
                +"\n Gender: M" +"\n ID: "+id+ "\n EID: "+ uniqueEmployeeNumber);
                 
            }
            else
            {
                Console.Write(" First Name: " + firstName + "\n Last name: " + lastName + "\n Age: " + age
                + "\n Gender: F" + "\n ID: " + id + "\n EID: " + uniqueEmployeeNumber);
            }

            Console.ReadLine();
        }
    }
}
