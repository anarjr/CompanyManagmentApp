using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Exception
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
