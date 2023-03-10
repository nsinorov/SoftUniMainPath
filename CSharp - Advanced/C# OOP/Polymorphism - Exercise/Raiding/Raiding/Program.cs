using Raiding.Core.Interfaces;
using Raiding.Core;
using Raiding.Factories.Interfaces;
using Raiding.Factories;
using Raiding.IO.Interfaces;
using Raiding.IO;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IHeroFactory heroFactory = new HeroFactory();

IEngine engine = new Engine(reader, writer, heroFactory);

engine.Run();