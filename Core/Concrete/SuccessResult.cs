using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class SuccessResult : ExceptionResult
    {
        public SuccessResult() : base(true)
        {
            
        }
        public SuccessResult(string message) : base(message, true)
        {
            
        }
    }
}
