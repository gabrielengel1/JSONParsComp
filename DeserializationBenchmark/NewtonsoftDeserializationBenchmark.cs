using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace JSONParsComp.DeserializationBenchmark
{
    public class SystemJsonDeserializationBenchmark : DeserializationBenchmarkBase
    {
        [Benchmark]
        public override void DeserializeBigObject()
        {
            var result = JsonConvert.DeserializeObject(bigObject);
        }
        
        [Benchmark]
        public override void DeserializeBigArray()
        {
            var result = JsonConvert.DeserializeObject<List<object>>(bigArray);
        }

        [Benchmark]
        public override void DeserializeRealWorldObject()
        {
            var result = JsonConvert.DeserializeObject(realWorldObject);
        }
    }
}