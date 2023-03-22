using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public abstract class MyValidationAttribute : Attribute
{
    public abstract bool IsValid(object obj);
}
