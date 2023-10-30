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
        public List<Crop> cropList = new List<Crop>();

        public CropManager()
        {
            cropList.Add(new Crop("Grass", 100, 1));
            cropList.Add(new Crop("Hay", 101, 2));

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
            foreach (Crop crop in cropList)
            {
                Console.WriteLine(crop.GetDescription());
            }  
        }


        
        private void AddCrop()
        {
            bool addComplete = false;
            Console.WriteLine("How many crop do you want to add?");
            while (!addComplete)
            {
                int amountToAdd;
                if (int.TryParse(Console.ReadLine(), out amountToAdd))
                {
                    for (int i = 0; i < amountToAdd; i++)
                    {
                        Console.WriteLine("Enter crop type: ");
                        string cropName = Console.ReadLine();

                        Console.WriteLine("Enter crop quantity");
                        int cropQuantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter crop ID: ");
                        int CropID = int.Parse(Console.ReadLine());


                        Crop newcrop = new Crop (cropName, cropQuantity, CropID);

                        cropList.Add(newcrop);

                        addComplete = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the number of animals. Please enter a valid number.");
                }
            }
        }
        




        private void RemoveCrop()
        {
            ViewCrops();
            Console.WriteLine("Enter the ID of the crop you want to remove!");
            int input = Convert.ToInt32(Console.ReadLine());

            Crop cropToRemove = cropList.FirstOrDefault(crop => crop.CropID == input); //Johnnys magiska fingrar

            if (cropToRemove != null)
            {
                cropList.Remove(cropToRemove);
                Console.WriteLine($"Crop with ID {input} has been removed.");
            }
            else
            {
                Console.WriteLine("No crop found with ID " + input);
            }
        }

        public Crop[] GetCrops()
        {
            Crop[] cropList = new Crop[0];
            return cropList;
        }
    }
}
