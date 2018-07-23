using BenchmarkDotNet.Attributes;
using System.Json;
using Newtonsoft.Json;

namespace JSONParsComp.SerializationBenchmark

{
    public abstract class SerializationBenchmarkBase : BenchmarkBase
    {
        protected object bigObject;
        protected object bigArray;
        protected object realWorldObject;

        protected object bigObjectString;
        protected object bigArrayString;
        protected object realWorldObjectString;


        [GlobalSetup]
        public void Setup()
        {
            var bigJsonObject = GenerateObjects(3);
            bigObject = JsonConvert.DeserializeObject(bigJsonObject);
            bigObjectString = JsonValue.Parse(bigJsonObject);

            var bigJsonArray = GenerateObjects(3);
            bigArray = JsonConvert.DeserializeObject(bigJsonArray);
            bigArrayString = JsonValue.Parse(bigJsonArray);

            realWorldObject = JsonConvert.DeserializeObject(BenchmarkConstants.RealWorldJson);
            realWorldObjectString = JsonValue.Parse(BenchmarkConstants.RealWorldJson);
        }

        public abstract void SerializeBigObject();
        public abstract void SerializeBigArray();
        public abstract void SerializeRealWorldObject();
    }
}