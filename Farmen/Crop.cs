using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class Crop : Entity
    {
        

        public string CropType {  get; set; }

        public int Quantity { get; set; } 

        public int CropID { get; set; }
        //va private?

        private static int nextCropID = 1;

        public Crop(string cropType, int quantity, int cropID) : base(cropType, quantity)
        {
            CropType = cropType;
            Quantity = quantity;
            CropID = cropID;
        }






        public override string GetDescription()
        {
            return $"This is croptype: {Name} and the Quantity is: {Quantity} and has number: {CropID}";
            //return $"Quantity is: {Quantity}";
        }


        public int AddCrop(int quantity)
        {
            Console.WriteLine("Enter the amount of weet to add:");
            string input = Console.ReadLine();

            // Try to parse the input as an integer
            if (int.TryParse(input, out int addedQuantity))
            {
                quantity += addedQuantity;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
            }

            return quantity;
        }



        public bool TakeCrop(int amoutToRemove)
        {
            Console.WriteLine("How much weet do you want to remove?");
            int amountToRemove = Convert.ToInt32(Console.ReadLine());
            if (Quantity < amoutToRemove)
            {
                Console.WriteLine("Can not remove more than we have! ");
                return false;
            }
            else
            {
                Quantity -= amoutToRemove;
                Console.WriteLine("New quantity is :",Quantity);
                return true;
            }
        }
    }
}
