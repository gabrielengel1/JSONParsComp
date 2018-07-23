using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace JSONParsComp.SerializationBenchmark
{
    public class NewtonsoftSerializationBenchmark : SerializationBenchmarkBase
    {
        [Benchmark]
        public override void SerializeBigObject()
        {
            var result = JsonConvert.SerializeObject(bigObject);
        }

        [Benchmark]
        public override void SerializeBigArray()
        {
            var result = JsonConvert.SerializeObject(bigArray);
        }

        [Benchmark]
        public override void SerializeRealWorldObject()
        {
            var result = JsonConvert.SerializeObject(realWorldObject);
        }
    }
}