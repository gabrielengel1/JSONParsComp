using BenchmarkDotNet.Attributes;
using System.Json;

namespace JSONParsComp.SerializationBenchmark
{
    public class SystemJsonSerializationBenchmark : SerializationBenchmarkBase
    {
        [Benchmark]
        public override void SerializeBigObject()
        {
            var result = JsonObject.Parse((string)bigObjectString);
        }

        [Benchmark]
        public override void SerializeBigArray()
        {
            var result = JsonObject.Parse((string)bigArrayString);
        }

        [Benchmark]
        public override void SerializeRealWorldObject()
        {
            var result = JsonObject.Parse((string)realWorldString);
        }
    }
}