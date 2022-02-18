using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    public class AnimalClinic
    {
        private static int patientId=1;
        private static int healedAnimalCount;
        private static int rehabilitatedAnimalCount;

        public static int PatientId { get => patientId;}
        public static int HealedAnimalCount { get => healedAnimalCount;}
        public static int RehabilitatedAnimalCount { get => rehabilitatedAnimalCount;}

        public static void HealedAnimal(string name, string breed)
        {
            Console.WriteLine($"Patient {patientId} [{name},{breed}] has been healed");
            patientId++;
            healedAnimalCount++;
        }
       public static void RehabilitateAnimal(string name, string breed)
        {
            Console.WriteLine($"Patient {patientId} [{name},{breed}] has been rehabilitated");
            patientId++;
            rehabilitatedAnimalCount++;

        }

        
    }
}
