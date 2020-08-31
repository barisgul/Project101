using log4net.Core;

namespace Project101
{
    public interface ILogger
    {
        string Info(string message);
        string Warn(string message);
        
    }
}