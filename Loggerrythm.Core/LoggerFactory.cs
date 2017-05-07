using System;
using System.Collections.Generic;

namespace Loggerrythm.Core
{
    /// <summary>
    /// https://www.thoughtworks.com/radar/techniques/structured-logging
    /// </summary>
    public static class LoggerFactory
    {
        /// <summary>
        /// Creates an instance of the 'Literate' console logger.
        /// </summary>
        /// <param name="loggerType"></param>
        /// <returns></returns>
        public static LoggerType Get(LoggerTypes loggerType)
        {
            return new LiterateLogger();
        }

        /// <summary>
        /// Creates an instance of the 'ElasticSearch' logger.
        /// </summary>
        /// <param name="elasticsearchNodeUris"></param>
        /// <param name="indexPattern"></param>
        /// <param name="minimumLogLevel"></param>
        /// <returns></returns>
        public static LoggerType Get(IEnumerable<Uri> elasticsearchNodeUris, string indexPattern, EventLogLevel minimumLogLevel)
        {
            return new ElasticLogger(elasticsearchNodeUris, indexPattern, minimumLogLevel);
        }
    }
}
