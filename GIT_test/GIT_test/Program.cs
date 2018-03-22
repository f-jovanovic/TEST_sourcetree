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

                Console.Clear();

                List<Person> people = new List<Person>();
                Person newPerson = null;

                switch (choice)
                {
                    case "1":
                        newPerson = new Person();
                        Console.WriteLine("Enter name: ");
                        newPerson.Name = Console.ReadLine();
                        Console.Clear();
                        string tmpChoice = "y";
                        while (tmpChoice=="y")
                        {
                            Console.WriteLine("Enter phone number: ");
                            newPerson.numbers.Add(Console.ReadLine());
                            Console.WriteLine("Enter another number? (y/n)");
                            Console.Write(": ");
                            tmpChoice = Console.ReadLine();
                        }
                        people.Add(newPerson);
                        Console.WriteLine("<<Continue>>");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            } while (choice != "x");
        }
    }
}
