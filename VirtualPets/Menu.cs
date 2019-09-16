using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    class Menu
    {
        public void TheGameMenu()
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("Enter 'L' to leave");
            Console.WriteLine("Type 'A' to add a pet to shelter.");

            Console.WriteLine("\nOnce you have a pet added:");
            Console.WriteLine("Type 'I' to view its information.");
            Console.WriteLine("Type 'S' to view its status.");

            Console.WriteLine("Type 'F' to give your pet food.");
            Console.WriteLine("Type 'P' to play with your pet.");
            Console.WriteLine("Type 'H' to heal your pet.");

        }
    }
}
