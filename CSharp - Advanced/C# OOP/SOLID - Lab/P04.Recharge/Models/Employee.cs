namespace P04.Recharge.Models
{
    using System;
    using P04.Recharge.Interfaces;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public void Sleep()
        {
        }
    }
}
