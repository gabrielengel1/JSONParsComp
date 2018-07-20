using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace JSONParsComp.SerializationBenchmark
{
    public class NewtonsoftSerializationBenchmark : SerializationBenchmarkBase
    {
        [Benchmark]
        public override void SerializeBigArray()
        {
            
        }

        [Benchmark]
        public override void SerializeBigObject()
        {

        }

        [Benchmark]
        public override void SerializeRealWorldObject()
        {
            
        }
    }
}