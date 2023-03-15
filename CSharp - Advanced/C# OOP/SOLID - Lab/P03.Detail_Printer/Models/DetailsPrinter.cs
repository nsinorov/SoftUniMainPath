﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Detail_Printer.Models
{
    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public string PrintDetails()
        {
            var sb = new StringBuilder();

            foreach (Employee employee in this.employees)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
