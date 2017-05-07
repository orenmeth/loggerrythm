using Elasticsearch.Net;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.Elasticsearch;
using System;
using System.Collections.Generic;

namespace Loggerrythm.Core
{
    public class ElasticLogger : LoggerType
    {
        Logger Logger;

        public ElasticLogger(IEnumerable<Uri> urls, string indexFormat, EventLogLevel minimumLogLevel)
        {
            LogEventLevel level = (LogEventLevel)minimumLogLevel;
            var elasticsearchSinkOptions = new ElasticsearchSinkOptions(new Uri("http://localhost:9200")) {
                AutoRegisterTemplate = true,
                IndexFormat = indexFormat
            };

            Logger = new LoggerConfiguration()
                .MinimumLevel.Is(level)
                .WriteTo
                .Elasticsearch(elasticsearchSinkOptions)
                .WriteTo
                .LiterateConsole()
                .CreateLogger();
        }

        public override void Log(EventLogLevel level, string message)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(message);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(message);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(message);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(message);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(message);
                    break;
                default:
                    Logger.Verbose(message);
                    break;
            }
        }

        public override void Log(EventLogLevel level, Exception exception, string message)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(exception, message);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(exception, message);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(exception, message);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(exception, message);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(exception, message);
                    break;
                default:
                    Logger.Verbose(exception, message);
                    break;
            }
        }

        public override void Log(EventLogLevel level, string message, object[] values)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(message, values);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(message, values);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(message, values);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(message, values);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(message, values);
                    break;
                default:
                    Logger.Verbose(message, values);
                    break;
            }
        }

        public override void Log(EventLogLevel level, Exception exception, string message, object[] values)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(exception, message, values);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(exception, message, values);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(exception, message, values);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(exception, message, values);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(exception, message, values);
                    break;
                default:
                    Logger.Verbose(exception, message, values);
                    break;
            }
        }

        public override void Log<T>(EventLogLevel level, string message, T value)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(message, value);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(message, value);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(message, value);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(message, value);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(message, value);
                    break;
                default:
                    Logger.Verbose(message, value);
                    break;
            }
        }

        public override void Log<T>(EventLogLevel level, Exception exception, string message, T value)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(exception, message, value);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(exception, message, value);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(exception, message, value);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(exception, message, value);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(exception, message, value);
                    break;
                default:
                    Logger.Verbose(exception, message, value);
                    break;
            }
        }

        public override void Log<T0, T1>(EventLogLevel level, string message, T0 value0, T1 value1)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(message, value0, value1);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(message, value0, value1);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(message, value0, value1);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(message, value0, value1);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(message, value0, value1);
                    break;
                default:
                    Logger.Verbose(message, value0, value1);
                    break;
            }
        }

        public override void Log<T0, T1>(EventLogLevel level, Exception exception, string message, T0 value0, T1 value1)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(exception, message, value0, value1);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(exception, message, value0, value1);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(exception, message, value0, value1);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(exception, message, value0, value1);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(exception, message, value0, value1);
                    break;
                default:
                    Logger.Verbose(exception, message, value0, value1);
                    break;
            }
        }

        public override void Log<T0, T1, T2>(EventLogLevel level, string message, T0 value0, T1 value1, T2 value2)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(message, value0, value1, value2);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(message, value0, value1, value2);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(message, value0, value1, value2);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(message, value0, value1, value2);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(message, value0, value1, value2);
                    break;
                default:
                    Logger.Verbose(message, value0, value1, value2);
                    break;
            }
        }

        public override void Log<T0, T1, T2>(EventLogLevel level, Exception exception, string message, T0 value0, T1 value1, T2 value2)
        {
            switch (level)
            {
                case EventLogLevel.Debug:
                    Logger.Debug(exception, message, value0, value1, value2);
                    break;
                case EventLogLevel.Information:
                    Logger.Information(exception, message, value0, value1, value2);
                    break;
                case EventLogLevel.Warning:
                    Logger.Warning(exception, message, value0, value1, value2);
                    break;
                case EventLogLevel.Error:
                    Logger.Error(exception, message, value0, value1, value2);
                    break;
                case EventLogLevel.Fatal:
                    Logger.Fatal(exception, message, value0, value1, value2);
                    break;
                default:
                    Logger.Verbose(exception, message, value0, value1, value2);
                    break;
            }
        }
    }
}
