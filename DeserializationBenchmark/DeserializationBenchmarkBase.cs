using BenchmarkDotNet.Attributes;

namespace JSONParsComp.DeserializationBenchmark
{
    public abstract class DeserializationBenchmarkBase : BenchmarkBase
    {
        protected string bigObject, bigArray, realWorldObject;

        public string getRealWorldObject(){
            return realWorldObject;
        }


        [GlobalSetup]
        public void Setup()
        {
            var bigJsonObject = GenerateObjects(3);
            bigObject = bigJsonObject.ToString();

            var bigJsonArray = GenerateArray(3);
            bigArray = bigJsonArray.ToString();

            realWorldObject = BenchmarkConstants.RealWorldJson.ToString();
        }

        public abstract void DeserializeBigObject();
        public abstract void DeserializeBigArray();
        public abstract void DeserializeRealWorldObject();
    }
}