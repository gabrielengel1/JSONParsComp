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
            bigObject = JsonObject.Parse(bigJsonObject);
            bigObjectString = (bigJsonObject).ToString();

            var bigJsonArray = GenerateObjects(3);
            bigArray = JsonArray.Parse(bigJsonArray);
            bigArrayString = (bigJsonArray).ToString();

            realWorldObject = JsonObject.Parse(BenchmarkConstants.RealWorldJson);
            realWorldObjectString = (BenchmarkConstants.RealWorldJson).ToString();
        }

        public abstract void SerializeBigObject();
        public abstract void SerializeBigArray();
        public abstract void SerializeRealWorldObject();
    }
}