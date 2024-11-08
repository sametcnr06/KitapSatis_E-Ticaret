using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class ExceptionResult : IExceptionResult
    {
        public bool Success { get; }

        public string Message { get; }
        public ExceptionResult(bool success)
        {
            Success = success;
        }
        public ExceptionResult(string message, bool success) : this(success)
        {
            Message = message;
        }
    }
}
