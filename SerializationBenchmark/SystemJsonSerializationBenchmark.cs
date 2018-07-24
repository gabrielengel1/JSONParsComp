using BenchmarkDotNet.Attributes;
using System.Json;

namespace JSONParsComp.SerializationBenchmark
{
    public class SystemJsonSerializationBenchmark : SerializationBenchmarkBase
    {
        [Benchmark]
        public override void SerializeBigObject()
        {
            var obj = bigObject as JsonObject;

            obj?.ToString();
        }

        [Benchmark]
        public override void SerializeBigArray()
        {
            var array = bigArray as JsonArray;

            array?.ToString();
        }

        [Benchmark]
        public override void SerializeRealWorldObject()
        {
            var obj = realWorldObject as JsonObject;

            obj?.ToString();
        }

        public override object ParseObject(string json)
        {
            return JsonObject.Parse(json);
        }

        public override object ParseArray(string json)
        {
            return JsonArray.Parse(json);
        }
    }
}