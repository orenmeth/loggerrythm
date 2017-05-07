using Loggerrythm.Core;
using System;
using System.Collections.Generic;

namespace Loggerrythm.Console.DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodeUris = new List<Uri> { new Uri("http://localhost:9200") };
            var elasticLogger = LoggerFactory.Get(nodeUris, "loggerrythm-index-{0:yyyy.MM}", EventLogLevel.Verbose);

            for (var i = 0; i < 10; i++)
            {
                elasticLogger.Log(EventLogLevel.Verbose, $"Loggerrythm.ElasticLogger: {i}", i);
                System.Threading.Thread.Sleep(500);
            }
            

            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
        }
    }
}