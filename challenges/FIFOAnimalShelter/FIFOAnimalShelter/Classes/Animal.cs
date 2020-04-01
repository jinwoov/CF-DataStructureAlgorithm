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

        /// <summary>
        ///  Construtor that will assign name and type when object is instantiated using arguments that been passed in
        /// </summary>
        /// <param name="name">name of the animal</param>
        /// <param name="type">type of the animal</param>
        public Animal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
            this.LineNumber = 0;
        }
    }
}
