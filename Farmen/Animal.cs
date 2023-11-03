using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class Animal : Entity
    {
         
        CropManager CropManager { get; set; }

        public string Species { get; set; } = "";
        private List<string> AcceptableCropTypes = new List<string>();

        private static int nextAnimalID = 1;

        public void AccetableCropType(List<string> acceptebleCropTypes)
        {
            acceptebleCropTypes.Add("grass");
            
           
        }
        public Animal(string name, string species) : base(name, nextAnimalID)
        {
            this.Species = species;
            nextAnimalID++; // Increment the static ID for the next animal.
        }


        public void Feed(CropManager cropList) //Ha med cropList
        {
            Console.WriteLine("What crop do you want to Feed with?");
            CropManager.GetCropList();
            
        }
       

        public override string GetDescription()
        {
            //return $"{Species} named {Name}, with ID number {Id}";
            return $"{Name}, {Species}, ID: {Id}";
        }
    }
}
