using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWeapon
{
    int AttackPoints { get; }

    int DurabilityPoints { get; }

    void Attack(ITarget target);
}
