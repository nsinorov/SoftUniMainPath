using Vehicles.Core.Interfaces;
using Vehicles.Core;
using Vehicles.IO;
using Vehicles.IO.Interfaces;
using Vehicles.Factories.Interfaces;
using Vehicles.Factories;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IVehicleFactory vehicleFactory = new VehicleFactory();

IEngine engine = new Engine(reader, writer, vehicleFactory);

engine.Run();