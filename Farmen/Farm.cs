using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class Farm
    {
        public Farm()
        {
            bool showMenu = true;


            while (showMenu)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break; 
                    case "3":
                        break;
                    case "4":   
                        break;
                    default:
                        break;
                }
            }

            static void DisplayMenu()
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Animal Menu.");
                Console.WriteLine("2. Crop Menu.");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("Q. Quit");
                Console.Write("Enter your choice: ");
            }
        }

    }
}
