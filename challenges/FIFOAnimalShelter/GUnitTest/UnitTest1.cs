using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace GUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCatToTheAnimalShelter()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Garfield", "cat");

            hospital.Enqueue(cat);

            Assert.Equal(cat, hospital.shelter[0]);
        }

        [Fact]
        public void CanAddMultipleAnimal()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Josie", "Cat");
            Animal dog = new Animal("Kudo", "Dog");
            Animal cat1 = new Animal("Garfield", "cat");



            hospital.Enqueue(cat);
            hospital.Enqueue(dog);
            hospital.Enqueue(cat1);

            Assert.Equal(cat, hospital.shelter[0]);
        }

        [Fact]
        public void CanQueueAndCheckIfAnimalIsInLine()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Josie", "Cat");
            Animal dog = new Animal("Kudo", "Dog");
            Animal cat1 = new Animal("Garfield", "cat");

            hospital.Enqueue(cat);
            hospital.Enqueue(dog);
            hospital.Enqueue(cat1);


            Assert.Equal(2, dog.LineNumber);
        }

        [Fact]
        public void CannotAddOtherAnimal()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Josie", "Cat");
            Animal dog = new Animal("Kudo", "Dog");
            Animal snake = new Animal("Ana", "Snake");

            hospital.Enqueue(cat);
            hospital.Enqueue(dog);
            Exception err = Record.Exception(() => hospital.Enqueue(snake));


            Assert.IsType<Exception>(err);
        }

        [Fact]
        public void CanDequeue()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Josie", "Cat");
            Animal dog = new Animal("Kudo", "Dog");
            Animal cat1 = new Animal("Garfield", "cat");

            hospital.Enqueue(cat);
            hospital.Enqueue(dog);
            hospital.Enqueue(cat1);
            Animal result = hospital.Dequeue(cat);

            Assert.Equal(cat, result);
        }


        [Fact]
        public void CanDequeueMultiple()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Josie", "Cat");
            Animal dog = new Animal("Kudo", "Dog");
            Animal cat1 = new Animal("Garfield", "cat");

            hospital.Enqueue(cat);
            hospital.Enqueue(dog);
            hospital.Enqueue(cat1);

            hospital.Dequeue(cat);
            hospital.Dequeue(cat);
            Animal result = hospital.Dequeue(dog);
            Assert.Equal(dog, result);
        }

        [Fact]
        public void CanDequeueEverything()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Josie", "Cat");
            Animal dog = new Animal("Kudo", "Dog");
            Animal cat1 = new Animal("Garfield", "cat");

            hospital.Enqueue(cat);
            hospital.Enqueue(dog);
            hospital.Enqueue(cat1);

            hospital.Dequeue(cat);
            hospital.Dequeue(cat);
            hospital.Dequeue(dog);
            int result = hospital.shelter.Count;

            Assert.Equal(0, result);
        }

        [Fact]
        public void DequeueingNotDogNorCatThrowsNull()
        {
            AnimalShelter hospital = new AnimalShelter();
            Animal cat = new Animal("Josie", "Cat");
            Animal dog = new Animal("Kudo", "Dog");
            Animal cat1 = new Animal("Garfield", "cat");
            Animal snake = new Animal("Ana", "snake");

            hospital.Enqueue(cat);
            hospital.Enqueue(dog);
            hospital.Enqueue(cat1);
            Animal result = hospital.Dequeue(snake);

            Assert.Null(result);
        }
    }
}
