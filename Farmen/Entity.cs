using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmen
{
    public abstract class Entity
    {
        
        public string Name { get; set; }
        public int Id { get; set; }
        //stod som protected men då kan vi inte använda name i animalManager? lös med getdes

        public Entity(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public abstract string GetDescription();
        
    }
}
