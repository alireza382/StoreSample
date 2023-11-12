using Dispatch.Application.Contracts;
using Dispatch.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch.Application.Model
{
    public class DipatchWrappingTypeFactory : IDispatchFactory
    {
        public IDispatchService CreateService(EWrappingType eWrappingType)
        {
            if (eWrappingType == EWrappingType.Breakable)
            {
              return  new BreakableDispatchService();
            }
            else
            {
               return  new NormalDispatchService();
            }
        }
    }
}
