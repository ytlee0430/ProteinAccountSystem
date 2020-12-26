using NLog;

namespace ProteinSystem.Log
{
    public class NLogger : ILogger
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public void Debug(string msg)
        {
            _logger.Debug(msg);
        }

        public void Error(string msg)
        {
            _logger.Error(msg);
        }

        public void Fatal(string msg)
        {
            _logger.Fatal(msg);
        }

        public void Trace(string msg)
        {
            _logger.Trace(msg);
        }

        public void Warn(string msg)
        {
            _logger.Warn(msg);
        }
    }
}