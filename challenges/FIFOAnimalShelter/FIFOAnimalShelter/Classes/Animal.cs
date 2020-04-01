using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int LineNumber { get; set; }

        public Animal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
            this.LineNumber = 0;
        }
    }
}
