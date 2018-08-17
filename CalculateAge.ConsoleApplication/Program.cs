using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAge.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth day (MM/dd/yyyy):");
            string date = Console.ReadLine();
            DateOfBirth dob = new DateOfBirth();
            if(dob.IsValidDate(date))
            {
                dob.ShowAge();
            }
            else
                Console.WriteLine("Incorrect date.");
        }
    }
}
