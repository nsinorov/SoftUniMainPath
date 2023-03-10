using WildFarm.Core;
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();

IAnimalFactory animalFactory = new AnimalFactory();
IFoodFactory foodFarctoty = new FoodFactory();


IEngine engine = new Engine(reader, writer, animalFactory, foodFarctoty);
engine.Run();
