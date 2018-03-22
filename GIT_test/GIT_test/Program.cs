using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("WELCOME\n1. Name entry \n2. Phone number entry\n3. Show all\n4. Search by name \nx - EXIT");
                Console.Write(": ");
                choice = Console.ReadLine();
            } while (choice != "x");
        }
    }
}
