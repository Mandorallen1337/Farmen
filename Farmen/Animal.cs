using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class Animal : Entity
    {
        Crop Crop { get; set; } 
        CropManager CropManager { get; set; }

        public string Species { get; set; } = "";
        private List<string> AcceptableCropTypes { get; set; }

        private static int nextAnimalID = 1;


        public Animal(string name, string species) : base(name, nextAnimalID)
        {
            this.Species = species;
            nextAnimalID++; // Increment the static ID for the next animal.
        }


        public void Feed(List<string> AcceptableCropTypes) //Ha med cropList
        {
            Console.WriteLine("What crop do you want to Feed with?");
            foreach( var item in AcceptableCropTypes)
            {
                Console.WriteLine(item);
            }
        }
       

        public override string GetDescription()
        {
            //return $"{Species} named {Name}, with ID number {Id}";
            return $"{Name}, {Species}, ID: {Id}";
        }
    }
}
