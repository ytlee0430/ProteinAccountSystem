namespace ProteinSystem.Log
{
    public static class LogUtil
    {
        private static ILogger _logger;

        private static ILogger Logger => _logger ?? (_logger = new NLogger());

        public static void Debug(string msg)
        {
            Logger.Debug(msg);
        }

        public static void Error(string msg)
        {
            Logger.Error(msg);
        }

        public static void Fatal(string msg)
        {
            Logger.Fatal(msg);
        }

        public static void Trace(string msg)
        {
            Logger.Trace(msg);
        }

        public static void Warn(string msg)
        {
            Logger.Warn(msg);
        }
    }
}