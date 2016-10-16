using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            string gender = Console.ReadLine();
            Console.Write("ID: ");
            uint ID = uint.Parse(Console.ReadLine());
            Console.Write("EN: ");
            uint EN = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("First name: {0}\nLast Name: {1}\nage: {2}\ngender: {3}\nID: {4}\nEN: {4}", FirstName, LastName, age, gender, ID, EN);
        }
    }
}