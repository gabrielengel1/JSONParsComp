using System;
using BenchmarkDotNet.Running;
using JSONParsComp.DeserializationBenchmark;

namespace JSONParsComp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new BenchmarkConfig();
            config.AllowNonOptimized(); // related to bug in benchmarkdotnet

            var summary = BenchmarkRunner.Run<NewtonsoftDeserializationBenchmark>(config);
            // Console.WriteLine(summary);
        }
    }
}