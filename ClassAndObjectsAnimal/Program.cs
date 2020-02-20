using System;

namespace ClassAndObjectsAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.tipAnimal = "caine";
            animal1.culoare = "negru";
            animal1.varsta = 2;
            Console.WriteLine("Animalul este: " + animal1.tipAnimal + "\nAre culoarea: " + animal1.culoare + "\nAre varsta: " + animal1.varsta + " ani");

            Animal animal2 = new Animal("pisica");
            animal2.culoare = "galbena";
            animal2.varsta = 1;
            Console.WriteLine();
            Console.WriteLine("Animalul este: " + animal2.tipAnimal + "\nAre culoarea: " + animal2.culoare + "\nAre varsta: " + animal2.varsta + " ani");

            Animal animal3 = new Animal("urs", "maro", 5);
            Console.WriteLine();
            Console.WriteLine("Animalul este: " + animal3.tipAnimal + "\nAre culoarea: " + animal3.culoare + "\nAre varsta: " + animal3.varsta + " ani");

        }
    }
}
