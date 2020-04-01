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
        /// <summary>
        /// Constructor that will have defaulted type and name to match the logic
        /// </summary>
        public AnimalShelter()
        {
            this.Cat = new Animal("", "CAT");
            this.Dog = new Animal("", "DOG");
            this.Order = 1;
        }

        // Accepts the animal
        public List<Animal> shelter = new List<Animal>();

        /// <summary>
        /// The method that will add cat or dog per user choice into the shelter
        /// </summary>
        /// <param name="animal">user's pet that will be added</param>
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

        /// <summary>
        /// Dequeueing from the list when its called and returns what has been dequeued 
        /// </summary>
        /// <param name="pref">preferred animal</param>
        /// <returns>Animal that has been dequeued</returns>
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
