using Prog4;
using System;

class Program
{
    static void Main(string[] args)
    {
        Cats[] cats = new Cats[]
        {
            new Cats("Mittens", "Persian", "Female", 4, "White", 500),
            new Cats("Whiskers", "Siamese", "Male", 2, "Brown", 450),
            new Cats("Simba", "Maine Coon", "Male", 6, "Orange", 600),
            new Cats("Luna", "Sphynx", "Female", 3, "Grey", 1000),
            new Cats("Oliver", "Ragdoll", "Male", 1, "White", 700)
        };

        Dogs[] dogs = new Dogs[]
        {
            new Dogs("Buddy", "Labrador Retriever", "Male", 3, "Yellow", 800),
            new Dogs("Molly", "Golden Retriever", "Female", 5, "Golden", 900),
            new Dogs("Max", "German Shepherd", "Male", 4, "Black", 950),
            new Dogs("Bella", "Poodle", "Female", 6, "White", 850),
            new Dogs("Charlie", "Bulldog", "Male", 2, "Brindle", 1200)
        };

        PrintCats(cats);
        Console.WriteLine();
        PrintDogs(dogs);

        cats[0].CatName = "Fluffy";
        cats[0].CatAge = 5;
        dogs[0].DogPrice = 750;
        dogs[1].IsAdopted();

        Console.WriteLine("\nUpdated Data:");
        PrintCats(cats);
        Console.WriteLine();
        PrintDogs(dogs);

        foreach (Dogs dog in dogs)
        {
            dog.IsAdopted();
        }

        Console.WriteLine("\nAll Dogs Adopted:");
        PrintCats(cats);
        Console.WriteLine();
        PrintDogs(dogs);
    }

    static void PrintCats(Cats[] cats)
    {
        foreach (Cats cat in cats)
        {
            Console.WriteLine(cat.ToString());
            Console.WriteLine();
        }
    }

    static void PrintDogs(Dogs[] dogs)
    {
        foreach (Dogs dog in dogs)
        {
            Console.WriteLine(dog.ToString());
            Console.WriteLine();
        }
    }
}
