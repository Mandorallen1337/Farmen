using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public class Entity
    {
        
        protected string Name { get; set; }
        public int Id { get; set; }

        public Entity(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public abstract void GetDescription()
        {
            //Create funktion to return value.
           
            
        }
    }
}
