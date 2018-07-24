using System.Collections.Generic;
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

        public override object ParseObject(string json)
        {
            return JsonConvert.DeserializeObject(json);
        }

        public override object ParseArray(string json)
        {
            return JsonConvert.DeserializeObject<List<object>>(json);
        }
    }
}