﻿using System;
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
            UC2AddressBook book = new UC2AddressBook(); // creating object of class
            string yes = "y";
            string y;

            do
            {
                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("1.AddNewContact\n2.ShowContact\n3.EditContact\n4.RmoveContact");
                Console.WriteLine("\nEnter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {

                    case 1:
                        Console.WriteLine("\nhow many contact you want to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            book.GetContactDetails();
                            Console.WriteLine("\n");    //through object accessing method 

                        }
                        break;
                    case 2:
                        book.putDetails();
                        break;

                    case 3:
                        /// Edit Contact
                        break;

                    case 4:
                        /// Remove Contact
                        break;

                    default:
                        break;
                }
                Console.WriteLine("do you want to continue? press...y/n");
                y = Console.ReadLine();

            } while (yes == y);

            Console.ReadLine();

        }
    }
    
}
