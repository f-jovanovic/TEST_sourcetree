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
            List<Person> people = new List<Person>();
            Person newPerson = null;

            do
            {
                Console.Clear();

                Console.WriteLine("WELCOME\n1. Data entry \n2. Show all\n3. Search by name \nx - EXIT");
                Console.Write(": ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        newPerson = new Person();
                        Console.WriteLine("Enter name: ");
                        newPerson.Name = Console.ReadLine();
                        Console.Clear();
                        string tmpChoice = "y";
                        while (tmpChoice == "y")
                        {
                            Console.WriteLine("Enter phone number: ");
                            newPerson.numbers.Add(Console.ReadLine());
                            Console.WriteLine("Enter another number? (y/n)");
                            Console.Write(": ");
                            tmpChoice = Console.ReadLine();
                        }
                        
                        people.Add(newPerson);
                        Console.WriteLine("\n\n<<Continue>>");
                        Console.ReadKey();
                        break;

                    case "2":
                        foreach (var item in people)
                        {
                            
                            Console.WriteLine("Name: " + item.Name);
                            int tmp = 0;
                            foreach (var help in item.numbers)
                            {
                                tmp++;
                                Console.WriteLine("Phone number {0}: " + help, tmp);
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("\n\n<<Continue>>");
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }

            } while (choice != "x");
        }
    }
}
