using System;

namespace Loggerrythm.Core
{
    public abstract class LoggerType
    {
        public abstract void Log(EventLogLevel level, string message);
        public abstract void Log(EventLogLevel level, Exception exception, string message);
        public abstract void Log(EventLogLevel level, string message, object[] values);
        public abstract void Log(EventLogLevel level, Exception exception, string message, object[] values);
        public abstract void Log<T>(EventLogLevel level, string message, T value);
        public abstract void Log<T>(EventLogLevel level, Exception exception, string message, T value);
        public abstract void Log<T0, T1>(EventLogLevel level, string message, T0 value0, T1 value1);
        public abstract void Log<T0, T1>(EventLogLevel level, Exception exception, string message, T0 value0, T1 value1);
        public abstract void Log<T0, T1, T2>(EventLogLevel level, string message, T0 value0, T1 value1, T2 value2);
        public abstract void Log<T0, T1, T2>(EventLogLevel level, Exception exception, string message, T0 value0, T1 value1, T2 value2);
    }
}
