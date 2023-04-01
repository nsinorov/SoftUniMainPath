using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Models
{
    public class SourDough : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering ingredients for Sourdough Bread.");
        }
        public override void Bake()
        {
            Console.WriteLine($"Baking the 12-Grain Bread. (20 minutes)");
        }
    }
}
