using P04.Recharge.Models;
using System;

namespace P04.Recharge
{
    class Program
    {
        static void Main()
        {
            Employee emp = new("1");
            Employee emp2 = new("2");
            Robot robot = new("#DCRX1", 100);

            robot.Work(5);
            emp.Work(5);
            emp.Sleep();
        }
    }
}
