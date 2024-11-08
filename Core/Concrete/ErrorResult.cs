using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class ErrorResult : ExceptionResult
    {
        public ErrorResult() : base(true)
        {
            
        }
        public ErrorResult(string message) : base(message,true)
        {
            
        }
    }
}
