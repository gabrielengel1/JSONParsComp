using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace JSONParsComp.SerializationBenchmark
{
    public class NewtonsoftSerializationBenchmark : SerializationBenchmarkBase
    {
        [Benchmark]
        public override void SerializeBigObject()
        {
            var jsonObj = JsonConvert.SerializeObject(bigObject);
        }

        [Benchmark]
        public override void SerializeBigArray()
        {
            var jsonObj = JsonConvert.SerializeObject(bigArray);
        }

        [Benchmark]
        public override void SerializeRealWorldObject()
        {
            var jsonObj = JsonConvert.SerializeObject(realWorldObject);
        }
    }
}