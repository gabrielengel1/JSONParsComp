using BenchmarkDotNet.Attributes;
using System.Json;

namespace JSONParsComp.SerializationBenchmark
{
    public class SystemJsonSerializationBenchmark : SerializationBenchmarkBase
    {
        [Benchmark]
        public override void SerializeBigObject()
        {
            var jsonObj = JsonObject.Parse(bigObject);
        }

        [Benchmark]
        public override void SerializeBigArray()
        {
            var jsonObj = JsonObject.Parse(bigArray);
        }

        [Benchmark]
        public override void SerializeRealWorldObject()
        {
            var jsonObj = JsonObject.Parse(realWorldJson);
        }
    }
}