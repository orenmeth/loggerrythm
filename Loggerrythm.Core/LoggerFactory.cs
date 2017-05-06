namespace Loggerrythm.Core
{
    public static class LoggerFactory
    {
        public static LoggerType Get(LoggerTypes loggerType)
        {
            switch (loggerType)
            {
                case LoggerTypes.ElasticLogger:
                    return new ElasticLogger();
                case LoggerTypes.LiterateLogger:
                    return new LiterateLogger();
                default:
                    return new ElasticLogger();
            }
        }
    }
}
