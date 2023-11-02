using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class CropManager
    {
        public List<Crop> cropList = new List<Crop>();

        public CropManager()
        {
            cropList.Add(new Crop("Grass", 100));
            cropList.Add(new Crop("Haaay", 200));
        }

        public List<Crop> GetCropList() {  return cropList; }
            
        Crop Crop { get; set; }
    
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
                        Console.Clear();
                        AddCrop();
                        break;
                    case "2":
                        Console.Clear();
                        RemoveCrop();
                        break;
                    case "3":
                        Console.Clear();
                        ViewCrops();
                        break;
                    case "4":
                        Console.Clear();
                        GetCrops();
                        break;
                    case "9":
                        Console.Clear();
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
                Console.WriteLine("9. Go back to main menu");
                Console.Write("Enter your choice: ");
            }
        }
        private void ViewCrops()
        {
            foreach (Crop crop in cropList)
            {
                Console.WriteLine(crop.GetDescription());
            }
            Console.WriteLine("\n");
        }


        
        private void AddCrop()
        {
            Console.WriteLine("Would you like to add *quantity* or a *new* crop?");
            string choice = Console.ReadLine();
            if (choice == "quantity")
            {
                ViewCrops();
                Console.WriteLine("Please enter ID of the crop you want to add more of: ");
                int pickID = int.Parse(Console.ReadLine());
                if (pickID == Crop.Id)
                {
                    Crop.AddCrops();
                }
            }
            if (choice == "new") 
            {
                Console.WriteLine("Enter the Crop Type: ");
                string inputType = Console.ReadLine();
                Console.WriteLine("Enter quantity to crop: ");
                int inputQuantity = int.Parse(Console.ReadLine());
                Crop newCrop = new Crop(inputType, inputQuantity);
                cropList.Add(newCrop);
                Console.Clear();
                Console.WriteLine($"{newCrop} har been added!\n");
                ViewCrops();
            }
            else
            {
                Console.WriteLine("Invalid choice! Going back to menu");
            }
            /*Console.WriteLine("Select the ID of the crop you'd like to add amount to: ");
            ViewCrops();
            int idToCrop = int.Parse(Console.ReadLine());
            int amountToAdd;
            if (idToCrop == Crop.Id)
            {
                Crop.AddCrops();
            }

            else
            {
                Console.WriteLine("This Crop ID doesn't exist. Creating new one");

            }*/

            /*if (int.TryParse(Console.ReadLine(), out amountToAdd))
            {
                for (int i = 0; i < amountToAdd; i++)
                {
                    Console.WriteLine("Enter crop type: ");
                    string cropName = Console.ReadLine();
                    //Crop newcrop = new Crop (cropName, cropQuantity);
                    //cropList.Add(newcrop);
                    //Console.WriteLine($"{cropQuantity} {cropName} added!\n");
                }
                Crop.AddCrops(amountToAdd);
            }
            else
            {
                Console.WriteLine("Invalid input for the number of animals. Please enter a valid number.");
            }*/
        }


        //private void RemoveCropQuantity()
        //{
        //    ViewCrops();
        //    Console.WriteLine("Enter the ID of the crop you want to remove:");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //
        //    Crop cropToRemove = cropList.FirstOrDefault(crop => crop.Id == input); // Find the crop by its ID
        //
        //    if (cropToRemove != null)
        //    {
        //        Console.WriteLine("Enter the quantity to remove:");
        //        int quantityToRemove = Convert.ToInt32(Console.ReadLine());
        //
        //        if (quantityToRemove > 0 && quantityToRemove <= cropToRemove.Quantity)
        //        {
        //            cropToRemove.Quantity -= quantityToRemove;
        //            if (cropToRemove.Quantity == 0)
        //            {
        //                cropList.Remove(cropToRemove); // Remove the crop if its quantity becomes zero
        //            }
        //            Console.WriteLine($"Removed {quantityToRemove} units of Crop with ID {input}. Remaining amount: {cropToRemove.Quantity}\n");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid quantity or not enough quantity to remove.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No crop found with ID " + input);
        //    }
        //}


        private void RemoveCrop()
        {
            ViewCrops();
            Console.WriteLine("Enter the ID of the crop you want to remove!");
            int input = Convert.ToInt32(Console.ReadLine());

            Crop cropToRemove = cropList.FirstOrDefault(crop => crop.Id == input); //Johnnys magiska fingrar

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


        // Till Niklas:
        // Ska detta med? JA, 

        public Crop[] GetCrops()
        {
            Crop[] crops = cropList.ToArray();
            return crops; //Funkar inte. blir systemerror.. försökt med GPT men får det inte att fungera.
            //Crop[] crops = GetCrops();
            //Crop[] = new Crop[cropList.Count];
            //Crop[] crops = new Crop[] { /* Populate with Crop objects / };
            // Call the GetCrops method to get the Crop[] array

        }
    }
}
