using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Bank Name: ");
            string bankName = Console.ReadLine();
            Console.Write("IBAN: ");
            string IBAN = Console.ReadLine();
            Console.Write("3 digits number: ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("\nName: {0} {1} {2}\nYour Balance is: {3}\nBank Name: {4}\nIBAN: {5}\nCode: {6}",
                firstName,
                middleName,
                lastName,
                balance,
                bankName,
                IBAN,
                code);
        }
    }
}