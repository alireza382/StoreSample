using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models.Dtos
{
    public class ConstraintResultDTO
    {
        public bool isValid { get; set; }
        public List<ContraintErrorType> contraintErrorTypes { get; set; }
    }
}
