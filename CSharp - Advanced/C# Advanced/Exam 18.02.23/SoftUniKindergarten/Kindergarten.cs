using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
    
   

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }     

        public List<Child> Registry { get; set; }
        public int ChildrenCount => Registry.Count;

        public bool AddChild(Child child)
        {
            if (ChildrenCount >= Capacity)
            {
                return false;
            }

            Registry.Add(child);
            return true;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] names = childFullName.Split(' ');
            string firstName = names[0];
            string lastName = names[1];

            for (int i = 0; i < Registry.Count; i++)
            {
                if (Registry[i].FirstName == firstName && Registry[i].LastName == lastName)
                {
                    Registry.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public Child GetChild(string childFullName)
        {
            if (Registry.Any(c => c.FirstName + " " + c.LastName == childFullName))
            {
                Child getChild = Registry.First(c => c.FirstName + " " + c.LastName == childFullName);
                return getChild;
            }

            return null;
        }

        public string RegistryReport()
        {
            StringBuilder stringBuilder= new();

            stringBuilder.AppendLine($"Registered children in {Name}:");

            if(ChildrenCount > 0)
            {
                foreach (var sortedChildren in Registry.OrderByDescending(child => child.Age)
                                         .ThenBy(child => child.LastName)
                                         .ThenBy(child => child.FirstName)
                                         .ToList())
                {
                    stringBuilder.AppendLine(sortedChildren.ToString());
                }
            }
             return stringBuilder.ToString().Trim();
        }
    }
}
