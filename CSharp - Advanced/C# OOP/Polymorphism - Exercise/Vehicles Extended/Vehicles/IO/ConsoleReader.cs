using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.IO.Interfaces;

namespace Vehicles.IO;

public class ConsoleReader : IReader
{
    public string ReadLine() => Console.ReadLine();
}
