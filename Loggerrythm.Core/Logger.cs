using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loggerrythm.Core
{
    public abstract class LoggerType {
        #region Verbose
        public abstract void Verbose(string message);
        public abstract void Verbose(Exception exception, string message);
        public abstract void Verbose(string message, object[] values);
        public abstract void Verbose(Exception exception, string message, object[] values);
        public abstract void Verbose<T>(string message, T value);
        public abstract void Verbose<T>(Exception exception, string message, T value);
        public abstract void Verbose<T0, T1>(string message, T0 value0, T1 value1);
        public abstract void Verbose<T0, T1>(Exception exception, string message, T0 value0, T1 value1);
        public abstract void Verbose<T0, T1, T2>(string message, T0 value0, T1 value1, T2 value2);
        public abstract void Verbose<T0, T1, T2>(Exception exception, string message, T0 value0, T1 value1, T2 value2);
        #endregion

        #region Debug
        public abstract void Debug(string message);
        public abstract void Debug(Exception exception, string message);
        public abstract void Debug(string message, object[] values);
        public abstract void Debug(Exception exception, string message, object[] values);
        public abstract void Debug<T>(string message, T value);
        public abstract void Debug<T>(Exception exception, string message, T value);
        public abstract void Debug<T0, T1>(string message, T0 value0, T1 value1);
        public abstract void Debug<T0, T1>(Exception exception, string message, T0 value0, T1 value1);
        public abstract void Debug<T0, T1, T2>(string message, T0 value0, T1 value1, T2 value2);
        public abstract void Debug<T0, T1, T2>(Exception exception, string message, T0 value0, T1 value1, T2 value2);
        #endregion

        #region Information
        #endregion

        #region Warning
        #endregion

        #region Error
        #endregion

        #region Fatal
        #endregion
    }

    public class ElasticLogger : LoggerType
    {
        Logger Log;

        public ElasticLogger()
        {
            Log = new LoggerConfiguration()
                .WriteTo
                .Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://localhost:9200"))
                {
                    AutoRegisterTemplate = true,
                    IndexFormat = "elasticlogger-index-{0:yyyy.MM}",
                    MinimumLogEventLevel = LogEventLevel.Debug
                })
                .CreateLogger();
        }

        #region Verbose
        public override void Verbose(string message)
        {
            Log.Verbose(message);
        }

        public override void Verbose(Exception exception, string message)
        {
            Log.Verbose(exception, message);
        }

        public override void Verbose(string message, object[] values)
        {
            Log.Verbose(message, values);
        }

        public override void Verbose(Exception exception, string message, object[] values)
        {
            Log.Verbose(exception, message, values);
        }

        public override void Verbose<T>(string message, T value)
        {
            Log.Verbose(message, value);
        }

        public override void Verbose<T>(Exception exception, string message, T value)
        {
            Log.Verbose(exception, message, value);
        }

        public override void Verbose<T0, T1>(string message, T0 value0, T1 value1)
        {
            Log.Verbose(message, value0, value1);
        }

        public override void Verbose<T0, T1>(Exception exception, string message, T0 value0, T1 value1)
        {
            Log.Verbose(exception, message, value0, value1);
        }

        public override void Verbose<T0, T1, T2>(string message, T0 value0, T1 value1, T2 value2)
        {
            Log.Verbose(message, value0, value1, value2);
        }

        public override void Verbose<T0, T1, T2>(Exception exception, string message, T0 value0, T1 value1, T2 value2)
        {
            Log.Verbose(exception, message, value0, value1, value2);
        }
        #endregion

        #region Debug
        public override void Debug(string message)
        {
            Log.Debug(message);
        }

        public override void Debug(Exception exception, string message)
        {
            Log.Debug(exception, message);
        }

        public override void Debug(string message, object[] values)
        {
            Log.Debug(message, values);
        }

        public override void Debug(Exception exception, string message, object[] values)
        {
            Log.Debug(exception, message, values);
        }

        public override void Debug<T>(string message, T value)
        {
            Log.Debug(message, value);
        }

        public override void Debug<T>(Exception exception, string message, T value)
        {
            Log.Debug(exception, message, value);
        }

        public override void Debug<T0, T1>(string message, T0 value0, T1 value1)
        {
            Log.Debug(message, value0, value1);
        }

        public override void Debug<T0, T1>(Exception exception, string message, T0 value0, T1 value1)
        {
            Log.Debug(exception, message, value0, value1);
        }

        public override void Debug<T0, T1, T2>(string message, T0 value0, T1 value1, T2 value2)
        {
            Log.Debug(message, value0, value1, value2);
        }

        public override void Debug<T0, T1, T2>(Exception exception, string message, T0 value0, T1 value1, T2 value2)
        {
            Log.Debug(exception, message, value0, value1, value2);
        }
        #endregion

        #region Information
        #endregion

        #region Warning
        #endregion

        #region Error
        #endregion

        #region Fatal
        #endregion
    }

    public static class LoggerFactory
    {
        public static LoggerType Get(LoggerTypes loggerType)
        {
            switch (loggerType)
            {
                case LoggerTypes.ElasticLogger:
                    return new ElasticLogger();
                default:
                    return new ElasticLogger();
            }
        }
    }

    public enum LoggerTypes
    {
        ElasticLogger = 0
    }
}
