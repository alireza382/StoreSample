using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models.Invariant
{
    public abstract class InvariantContraintDecorator : IModelConstraint
    {
        protected IModelConstraint _modelConstraint;

        public decimal Price { get; set; }
        public InvariantContraintDecorator(IModelConstraint modelConstraint)
        {
                this._modelConstraint = modelConstraint;
        }

        public virtual ConstraintResultDTO IsSatisfied() => _modelConstraint.IsSatisfied();
    }
}
