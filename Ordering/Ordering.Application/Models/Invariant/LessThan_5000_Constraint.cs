using AutoMapper.Configuration.Conventions;
using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models.Invariant
{
    public class LessThan_5000_Constraint : InvariantContraintDecorator
    {
        private const decimal _price = 5000;
        public LessThan_5000_Constraint(IModelConstraint modelConstraint) : base(modelConstraint)
        {
        }
        public override ConstraintResultDTO IsSatisfied()
        {
            bool isValid = (base.IsSatisfied().isValid & Price > _price);
            List<ContraintErrorType> errors = base.IsSatisfied().contraintErrorTypes;
            if (!isValid) { errors.Add(ContraintErrorType.OrderIsLessThan5000Toman); }
            return new ConstraintResultDTO { isValid = isValid,
            contraintErrorTypes = errors
            };
        }
    }
}
