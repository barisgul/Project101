using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project101
{
    public class Logger : ILogger
    {
        public string Info(string message)
        {
            return message;
        }

        public string Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
