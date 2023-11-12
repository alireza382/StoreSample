using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models.Invariant
{
    public class ConstraintValidatorInvariant : IModelConstraint
    {


        ConstraintResultDTO IModelConstraint.IsSatisfied()=> new ConstraintResultDTO { isValid = true };
        
    }
}
