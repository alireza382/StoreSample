using Dispatch.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch.Application.Model
{
    public class BreakableDispatchService : IDispatchService
    {
        public Task<bool> SendAsync()
        {
            throw new NotImplementedException();
        }
    }
}
