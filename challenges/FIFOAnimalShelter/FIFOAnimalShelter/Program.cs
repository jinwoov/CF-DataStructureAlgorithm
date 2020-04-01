using FIFOAnimalShelter.Classes;
using System;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to the Animal Shelter");
            Console.WriteLine();
            AnimalHospital();

        }
        /// <summary>
        /// Running the methods in the animalshelter class to test everything is working
        /// </summary>
        static void AnimalHospital()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal("Garfield", "Cat");
            Animal dog = new Animal("Kudo", "Dog");

            Console.WriteLine($"This is when {cat.Type} enqueued");

            shelter.Enqueue(cat);

            Console.WriteLine($"{shelter.shelter[0].Name} is checked in!");
            Console.WriteLine();

            Console.WriteLine($"This is when another animal, {dog.Type} is checked in");
            
            shelter.Enqueue(dog);

            Console.WriteLine($"{shelter.shelter[1].Name} is checked in!");


            Console.WriteLine();

            Console.WriteLine($"There are {shelter.shelter.Count} animals in the shelter");
            Console.WriteLine();

            Console.WriteLine($"This is when first animal is checkout");

            Animal result = shelter.Dequeue(cat);

            Console.WriteLine($"{result.Name}, the {result.Type.ToLower()} is checked out");

            Console.WriteLine();

            Console.WriteLine($"Only {shelter.shelter.Count} amount of animal/s are left");

        }
    }
}
