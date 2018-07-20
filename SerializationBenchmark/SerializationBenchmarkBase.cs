using BenchmarkDotNet.Attributes;

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
            bigObject = ParseBigObject(bigJsonObject.ToString());

            var bigJsonArray = GenerateObjects(3);
            bigArray = ParseBigArray(bigJsonArray);
        }

        protected abstract object ParseBigObject(string json);
        protected abstract object ParseBigArray(string json);
        protected abstract object ParseRealWorldObject(string json);

        public abstract void SerializeBigObject();
        public abstract void SerializeBigArray();
        public abstract void SerializeRealWorldObject();
    }
}