using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagramsQuest3
{
   
   
    public class Vaccine
    {
        public string Name { get; set; }
          public string Type { get; set; }

        public Vaccine(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }

    
    public class Animal
    {
      public string Type { get; set; }
        public string Breed { get; set; }
        public bool Carnivore { get; set; }

     public Animal(string type, string breed, bool carnivore)
        {
            Type = type;
            Breed = breed;
            Carnivore = carnivore;
        }
    }

   
    public class PetInformation
    {
        public List<string> Traits { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public PetInformation()
        {
            Traits = new List<string>();
            Vaccines = new List<Vaccine>();
           }

        public bool Contains(Vaccine vaccine)
        {
            return Vaccines.Contains(vaccine);
        }
    }

    
    public class Owner
    {
        public string Name { get; set; }

     public Owner(string name)
      {
            Name = name;
        }
    }

    
    public class Pet
    {
        private Guid Id { get; set; }
       public string Name { get; set; }
        public int Age { get; set; }
         public Owner Owner { get; set; }
        public Animal Animal { get; set; }
        public PetInformation PetInfo { get; set; }

        public Pet(string name, int age, Owner owner, Animal animal)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Owner = owner;
            Animal = animal;
             PetInfo = new PetInformation();
        }

        private bool IsHerbivore()
        {
               return !Animal.Carnivore;
        }

        public void Feed()
        {
            if (IsHerbivore())
            {
            Console.WriteLine($"{Name} is eating plants.");
            }
            else
               {
                Console.WriteLine($"{Name} is eating meat.");


            }
    }
    }

   
    public interface IIdentifiable
    {
        string GetId();

       }

    public class ExperiencedProtocol : IIdentifiable
    {
        public string GetId()
        {
            return "Experience ID";
          }

    }

   
   
}
