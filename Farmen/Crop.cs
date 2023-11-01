using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class Crop : Entity
    {
        CropManager CropManager {  get; set; }

        private string CropType {  get; set; }

        private int Quantity { get; set; } 
        //va private?

        private static int nextCropID = 1;


        public Crop(string cropType, int quantity) : base(cropType, nextCropID)
        {
            CropType = cropType;
            Quantity = quantity;
            nextCropID++;
        }



        public override string GetDescription()
        {
            return $"Crop type: {Name}, remaining amount: {Quantity} ID: {Id}";
            //return $"Quantity is: {Quantity}";
        }


    
        public int AddCrops(int uantity) //Om crop existerar och bara ska ha quantity
        {
            // Try to parse the input as an integer
            Console.WriteLine("Enter the amount you'd like to add: ");
            int addQuantity = int.Parse(Console.ReadLine());
            Quantity += addQuantity;
            return Quantity;
        }
       




        public bool TakeCrop(int amoutToRemove)
        {
            Console.WriteLine("How much Wheat do you want to remove?");
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
