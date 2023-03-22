using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes.Attributes;

public class MyRequiredAttribute : MyValidationAttribute
{
    public override bool IsValid(object obj)
        => obj is not null;
}
