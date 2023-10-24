using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class Animal : Entity
    {


        public string Species { get; set; } = "";
        private List<string> AcceptebleCropTypes { get; set; }
        
        
        
        public Animal(string name, int id, string species ) : base(name, id)
        {
            
            this.Species = species;
            

        }

        public void Feed()
        {
            
            Console.WriteLine("What crop do you want to feed with?");
            foreach( var item in AcceptebleCropTypes)
            {
                Console.WriteLine(item);
            }
            
        }
       

        public override string GetDescription()
        {
            return $"This is a {Species}";
        }
        



    }
}
