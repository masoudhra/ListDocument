using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_document_sheet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string greeting = "Hello  ";
            string name = "Masoud";
            Console.WriteLine(greeting.Length);

            Console.WriteLine(greeting.Trim().Length);
            Console.WriteLine(greeting.Length);
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.ToUpper());

            string fullGreeting = greeting + name;
            Console.WriteLine(fullGreeting);
            string fullGreeting2 = string.Concat(greeting, name);
            Console.WriteLine(fullGreeting2);
            Console.WriteLine(greeting[0]);
            Console.WriteLine(greeting.IndexOf("l"));
            Console.WriteLine(fullGreeting.Substring(6, 4));

            Console.ReadKey(); 
        }
    }
}
