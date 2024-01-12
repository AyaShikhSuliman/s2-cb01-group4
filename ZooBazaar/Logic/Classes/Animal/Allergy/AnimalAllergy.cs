using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Animal.Allergy
{
    public class AnimalAllergy
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public AnimalAllergy(int? id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
