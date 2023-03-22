using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core.Commands;

public class HelloCommand : ICommand
{
    public string Execute(string[] args)
        => $"Hello, {args[0]}";
}
