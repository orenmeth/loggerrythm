using Loggerrythm.Core;

namespace Loggerrythm.Console.DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LoggerFactory.Get(LoggerTypes.ElasticLogger);
            logger.Debug("Initial test");
            System.Console.ReadKey();
        }
    }
}