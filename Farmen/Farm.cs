using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class Farm
    {
        //Farm, Klassen innehåller en MainMenu() från vilken man kan kalla en av de fyra andra slags managers.
        //Building, Worker, Crop eller Animal-manager. Varje av dessa managers finns som variabler i Farm.
        AnimalManager animalManager = new AnimalManager();
        CropManager cropManager = new CropManager();
        public void Run()
        {
            bool showMenu = true;
            



            while (showMenu)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        animalManager.Run();
                        break;
                    case "2":
                        cropManager.CropmanagerMenu();
                        break; 
                    case "3":
                        break;
                    case "4":   
                        break;
                    case "9":
                        showMenu = false;
                         break;
                    default:
                        break;
                }
            }

            static void DisplayMenu()
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Animal Manager Menu.");
                Console.WriteLine("2. Crop Manager Menu.");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("9. Quit");
                Console.Write("Enter your choice: ");
            }
        }

    }
}
