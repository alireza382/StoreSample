using Dispatch.Application.Contracts;
using Dispatch.Domain.Entity;
using Dispatch.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dispatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispatchController : ControllerBase
    {
        private  IDispatchService _dispatchService;
        private readonly IDispatchFactory _dispatchFactory;

        public DispatchController(IDispatchFactory dispatchFactory)
        {
                _dispatchFactory = dispatchFactory;
        }
        public async Task<int> SetAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<bool>> WrappingType(EWrappingType eWrappingType,CancellationToken cancellationToken = default)
        {
            ;
            return  Ok(true);
        }

        public async Task<ActionResult<bool>> Send()
        {
                return await _dispatchService.SendAsync();
        }
    }
}
