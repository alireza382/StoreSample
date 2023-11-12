using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models.Invariant
{
    public class PermitedTimeConstraint : InvariantContraintDecorator
    {
        public PermitedTimeConstraint(IModelConstraint modelConstraint) : base(modelConstraint)
        {
        }

        public override ConstraintResultDTO IsSatisfied()
        {
            var permitedTime_Start = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,8,0,0) ;
            var permitedTime_End  = new     DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 0, 0);
            bool isValid =  base.IsSatisfied().isValid & (DateTime.Now > permitedTime_End) & (DateTime.Now < permitedTime_Start );
            return new ConstraintResultDTO { isValid = isValid };
       }
    }
}
