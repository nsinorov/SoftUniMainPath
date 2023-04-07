using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies
{
    public class Gingerbread : Delicacy
    {
        public Gingerbread(string delicacyName) : base(delicacyName, 4.00)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
