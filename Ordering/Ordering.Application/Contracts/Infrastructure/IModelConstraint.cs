﻿using Ordering.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrastructure
{
    public interface IModelConstraint
    {

        ConstraintResultDTO IsSatisfied();
    }
}
