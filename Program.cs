using System;
using BenchmarkDotNet.Running;
using JSONParsComp.DeserializationBenchmark;
using JSONParsComp.SerializationBenchmark;

namespace JSONParsComp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new BenchmarkConfig();
            config.AllowNonOptimized(); // related to bug in benchmarkdotnet

            var switcher = new BenchmarkSwitcher(new [] {
                typeof(NewtonsoftDeserializationBenchmark),
                typeof(SystemJsonDeserializationBenchmark),
                typeof(NewtonsoftSerializationBenchmark),
                typeof(SystemJsonSerializationBenchmark),
            });

            switcher.Run(args, config);
        }
    }
}