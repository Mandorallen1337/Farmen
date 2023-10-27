using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    internal class CropManager
    {
        List<Crop> cropList = new List<Crop>();

        

        public CropManager()
        {
            cropList.Add(new Crop("Grass", 100));
            

        }
            
    
        public void CropmanagerMenu()
        {
            bool showMenu = true;


            while (showMenu)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddCrop();
                        break;
                    case "2":
                        RemoveCrop();
                        break;
                    case "3":
                        ViewCrops();
                        break;
                    case "4":
                        GetCrops();
                        break;
                        case "5":

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
                Console.WriteLine("Crop manager menu.");
                Console.WriteLine("1. Add crop.");
                Console.WriteLine("2. Remove crop.");
                Console.WriteLine("3. View crops.");
                Console.WriteLine("4. Get crops.");

                Console.WriteLine("9. Quit");
                Console.Write("Enter your choice: ");
            }
        }
        private void ViewCrops()
        {
            //använd GetDes.
            foreach(Crop crop in cropList)
            {
                Console.WriteLine(" Type: " + crop.Name + "." + " Quantity: " + crop.Quantity + ". ");
            }
            
            
            
        }
        private void AddCrop()
        {

            //Add crop/quantity



        }
        private void RemoveCrop()
        {
            //Remove crop/Quantity
        }
        public Crop[] GetCrops()
        {
            Crop[] cropList = new Crop[0];
            return cropList;
        }

    }
}
