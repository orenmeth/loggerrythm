using Loggerrythm.Core;

namespace Loggerrythm.Console.DotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var elasticLogger = LoggerFactory.Get(LoggerTypes.ElasticLogger);

            for (var i = 0; i < 100; i++)
            {
                elasticLogger.Log(EventLogLevel.Error, $"ElasticLogger: {i}", i);
            }

            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
        }
    }
}
