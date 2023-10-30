using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Farmen
{
    public class AnimalManager
    {
        public List<AnimalManager> CropList = new List<AnimalManager>();

        public List<Animal> animalList = new List<Animal>();

        public AnimalManager()
        {

            animalList.Add(new Animal("Kajsa", 1, "Cow"));
            animalList.Add(new Animal("Lisa", 2, "Cow"));
            animalList.Add(new Animal("Maja", 3, "Cow"));
            animalList.Add(new Animal("Rosa", 4, "Cow"));
            animalList.Add(new Animal("Jenny", 5, "Cow"));



        }



        public AnimalManager(List<AnimalManager> cropList, List<Animal> animalList)
        {
            CropList = cropList;
            this.animalList = animalList;
        }

        public void Run()
        {
            bool showMenu = true;


            while (showMenu)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddAnimals();
                        break;
                    case "2":
                        RemoveAnimal();
                        break;
                    case "3":
                        ViewAnimals();
                        break;
                    case "4":
                        FeedAnimals();
                        break;
                    case "9":
                        showMenu = false;
                        break;
                    default:
                        break;
                }
            }

            static void DisplayMenu()
            {
                Console.WriteLine("Animal manager menu.");
                Console.WriteLine("1. Add animal.");
                Console.WriteLine("2. Remove animal.");
                Console.WriteLine("3. View animals.");
                Console.WriteLine("9. Quit");
                Console.Write("Enter your choice: ");
            }
        }

        private void FeedAnimals()
        {
            //skicka med crop. Vilket djur och om det är rätt crop.
        }

        private void ViewAnimals()
        {
            //Använda GetDescriptions.
            foreach (Animal animals in animalList)
            {
                Console.WriteLine(animals.GetDescription());
                //Console.WriteLine(animals.Name + " " + animals.Id + " " + animals.Species + ". ");

            }
        }

        private void RemoveAnimal()
        {
            ViewAnimals();
            Console.WriteLine("Enter the ID of the animal you want to remove!");
            int input = Convert.ToInt32(Console.ReadLine());

            Animal animalToRemove = animalList.FirstOrDefault(animal => animal.Id == input); //Johnnys magiska fingrar

            if (animalToRemove != null)
            {
                animalList.Remove(animalToRemove);
                Console.WriteLine($"Animal with ID {input} has been removed.");
            }
            else
            {
                Console.WriteLine("No animal found with ID " + input);
            }
        }

        private void AddAnimals()
        {
            bool addComplete = false;
            Console.WriteLine("How many animals do you want to add?");
            while (!addComplete)
            {
                int amountToAdd;
                if (int.TryParse(Console.ReadLine(), out amountToAdd))
                {
                    for (int i = 0; i < amountToAdd; i++)
                    {
                        Console.WriteLine("Enter Animal name: ");
                        string inputName = Console.ReadLine();

                        Console.WriteLine("Enter Animal ID: ");
                        int inputId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Animal species: ");
                        string inputSpecies = Console.ReadLine();


                        Animal newanimal = new Animal(inputName, inputId, inputSpecies);

                        animalList.Add(newanimal);

                        addComplete = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the number of animals. Please enter a valid number.");
                }
            }
        }
    }
}
        



