using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class Animal : Entity
    {
        

        public string Species {  get; set; }
        //private List<string> AcceptebleCropTypes { get; set; }

        public Animal(string name, int id, string species/*, string accepetebleCropTypes */) : base(name, id)
        {
            species = Species;
            //this.AcceptebleCropTypes = accepetebleCropTypes;

        }
        public  override void GetDescription(string name, int id)
        {
            
        }
    }
}
