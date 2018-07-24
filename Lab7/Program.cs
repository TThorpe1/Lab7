using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("Please enter the requested information");
            string input = Console.ReadLine();


            // 1 .@"^[A-Z]{1}[a-zA-Z]{0,29}$"

            // 2 .@"^.{5,30}\@.{5,10}\..{2,3}$"

            // 3. @"^\d{3}\-\d{3}\-\d{4}$"

            // 4. @"^\d{2}\/\d{2}\/\d{4}$"


            if (Regex.IsMatch(input, @""))
            {
                Console.WriteLine("matching");

            }
            else {
                Console.WriteLine("not matching!");
            }
        }
    }
}
