using BenchmarkDotNet.Attributes;

namespace JSONParsComp.SerializationBenchmark
{
    public class SystemJsonSerializationBenchmark : SerializationBenchmarkBase
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