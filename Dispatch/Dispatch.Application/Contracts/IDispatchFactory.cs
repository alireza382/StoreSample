﻿using Dispatch.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch.Application.Contracts
{
    public interface IDispatchFactory
    {
        IDispatchService CreateService(EWrappingType eWrappingType);
    }
}
