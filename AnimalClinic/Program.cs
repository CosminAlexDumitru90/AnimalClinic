using System;

namespace AnimalClinic
{
    class Program
    {
        static void Main(string[] args)
        {
        
            for(; ; )
            {
                string input = Console.ReadLine().ToLower();
                string[] result = input.Split(" ");
                if(input == "end")
                {
                    Console.WriteLine($"Total animals have been healed: {AnimalClinic.HealedAnimalCount}");
                    Console.WriteLine($"Total animals have been rehabilitated: {AnimalClinic.RehabilitatedAnimalCount}");
                    break;
                }
                if(result[2] == "heal")
                {
                    Animal animal = new Animal(result[0], result[1]);
                    AnimalClinic.HealedAnimal(animal.Name,animal.Breed);
                }
               if(result[2] == "rehabilitate")
                {
                    Animal animal = new Animal(result[0], result[1]);
                    AnimalClinic.RehabilitateAnimal(animal.Name, animal.Breed);
                }
            }
        }

        
    }
}
