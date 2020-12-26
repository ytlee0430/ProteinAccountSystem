namespace ProteinSystem.Log
{
    public interface ILogger
    {
        void Debug(string msg);

        void Error(string msg);

        void Fatal(string msg);

        void Trace(string msg);

        void Warn(string msg);
    }
}