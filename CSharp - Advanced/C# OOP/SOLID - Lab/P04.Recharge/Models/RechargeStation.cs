using P04.Recharge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Recharge.Models
{
    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}
