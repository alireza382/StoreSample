using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models.Dtos
{
    public class ResponseResult<T> : MarshalByRefObject
    {

        public bool IsSucess {  get; set; }

        public string Message { get; set; }
        public T Value { get; set; }
    }
}
