using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
   public class Animal
    {
        private string name;
        private string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public string Name { get => name; set => name = value; }
        public string Breed { get => breed;}
    }
}
