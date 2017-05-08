using System;
using System.Collections.Generic;
using Loggerrythm.Core;

namespace Loggerrythm.Console.DotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodeUris = new List<Uri> { new Uri("http://localhost:9200") };
            var elasticLogger = LoggerFactory.Get(nodeUris, "loggerrythm-index-{0:yyyy.MM}", EventLogLevel.Verbose);

            for (var errorNumber = 0; errorNumber < 24; errorNumber++)
            {
                elasticLogger.Log(EventLogLevel.Warning, $"Loggerrythm.ElasticLogger: {errorNumber}", errorNumber);
                System.Threading.Thread.Sleep(50);
            }


            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
        }
    }
}
