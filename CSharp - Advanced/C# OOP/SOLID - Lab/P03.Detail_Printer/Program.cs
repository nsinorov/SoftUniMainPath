using P03.Detail_Printer.Models;
using System.Collections.Generic;
using System;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            var employee = new Employee("Employee");
            var manager = new Manager("Manager", new[] { "Doc 1", "Doc 2", "Doc 3" });
            var detailsPrinter = new DetailsPrinter(new List<Employee>(new[] { employee, manager }));
            Console.WriteLine(detailsPrinter.PrintDetails());
        }
    }
}
