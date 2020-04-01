using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Cat { get; set; }
        public Animal Dog { get; set; }

        public int Order { get; set; }
        public AnimalShelter()
        {
            this.Cat = new Animal("", "CAT");
            this.Dog = new Animal("", "DOG");
            this.Order = 1;
        }

        public List<Animal> shelter = new List<Animal>();

        public void Enqueue(Animal animal)
        {
            animal.LineNumber = this.Order;
            animal.Type = animal.Type.ToUpper();
            if (animal.Type == Cat.Type || animal.Type == Dog.Type) 
            {
                shelter.Add(animal);
                Order++;
            }
            else
            {
                throw new Exception("You have enter wrong animal you better check it out in other hospital");
            }
        }

        public Animal Dequeue(Animal pref)
        {
            pref.Type = pref.Type.ToUpper();
            foreach (var animals in shelter)
            {
                if(animals.Type == pref.Type)
                {
                    shelter.Remove(animals);
                    return animals;
                }
            }

            return null;
        }

    }
}
