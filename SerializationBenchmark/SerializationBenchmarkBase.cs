using BenchmarkDotNet.Attributes;

namespace JSONParsComp.SerializationBenchmark

{
    public abstract class SerializationBenchmarkBase : BenchmarkBase
    {
        protected object bigObject;
        protected string bigArray;
        protected object realWorldObject;

        [GlobalSetup]
        public void Setup(){
            var bigJsonObject = GenerateObjects(3);
            bigObject = bigJsonObject.ToString();

            var bigJsonArray = GenerateObjects(3);
            bigArray = bigJsonArray;

            var realWorldObjectString = DeserializationBenchmark.DeserializationBenchmarkBase.getRealWorldObject();
            realWorldObject = realWorldObjectString;
        }

        public abstract void SerializeBigObject();
        public abstract void SerializeBigArray();
        public abstract void SerializeRealWorldObject();
    }
}