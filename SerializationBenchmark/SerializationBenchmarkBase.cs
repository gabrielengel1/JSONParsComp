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


        [GlobalSetup]
        public void Setup()
        {
            var bigJsonObject = GenerateObjects(3);
            bigObject = ParseObject(bigJsonObject.ToString());

            var bigJsonArray = GenerateArray(3);
            bigArray = ParseArray(bigJsonArray.ToString());

            realWorldObject = ParseObject(BenchmarkConstants.RealWorldJson);
        }

        public abstract object ParseObject(string json);
        public abstract object ParseArray(string json);

        public abstract void SerializeBigObject();
        public abstract void SerializeBigArray();
        public abstract void SerializeRealWorldObject();
    }
}