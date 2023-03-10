using WildFarm.Core.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;

        private readonly ICollection<IAnimal> animals;

        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;

            animals = new List<IAnimal>();
        }
        public void Run()
        {
            string command = string.Empty;

            while ((command = reader.ReadLine()) != "End")
            {
                IAnimal animal = null;
                try
                {
                    animal = CreateAnimal(command);

                    IFood food = CreateFood();

                    writer.WriteLine(animal.ProduseSound());

                    animal.Eat(food);
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }
                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }

        private IAnimal CreateAnimal(string command)
        {
            string[] animalTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return animalFactory.CreateAnimal(animalTokens);
        }

        private IFood CreateFood()
        {
            string[] foodTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);

            return foodFactory.CreateFood(foodType, foodQuantity);
        }
    }
}
