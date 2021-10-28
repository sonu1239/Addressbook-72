using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook72
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book");

            UC1AddressBook book = new UC1AddressBook(); // creating object of class

            book.GetContactDetails();   //through object accessing method 
            book.putDetails();
        }
    }
}
