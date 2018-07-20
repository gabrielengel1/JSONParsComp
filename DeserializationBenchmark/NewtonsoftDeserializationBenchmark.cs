using System.Json;
using BenchmarkDotNet.Attributes;

namespace JSONParsComp.DeserializationBenchmark
{
    public class NewtonsoftDeserializationBenchmark : DeserializationBenchmarkBase
    {
        [Benchmark]
        public override void DeserializeBigObject()
        {
            var result = JsonObject.Parse(bigObject);
        }

        [Benchmark]
        public override void DeserializeBigArray()
        {
            var result = JsonArray.Parse(bigArray);
        }

        [Benchmark]
        public override void DeserializeRealWorldObject()
        {
            var result = JsonObject.Parse(realWorldObject);
        }
    }
}
