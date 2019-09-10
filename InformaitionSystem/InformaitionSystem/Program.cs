using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaitionSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = " ";
            string Age = " ";
            string Address = " ";
            string Contact = " ";
            Console.WriteLine("Enter Your Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            Age = Console.ReadLine();
            Console.WriteLine("Enter Your Address : ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Your Contact Number : ");
            Contact = Console.ReadLine();
            Console.WriteLine("Your Informatin is : " + "\n " + " Name: " + Name + " \n " + " Age: " +
            Age + " \n " + " Address: " + Address + "\n" + "  Contact: " + Contact + " \n ");
            Console.ReadKey();
        }
    }
}
