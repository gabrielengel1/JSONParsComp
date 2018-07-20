using BenchmarkDotNet.Attributes;

namespace JSONParsComp.DeserializationBenchmark
{
    public abstract class DeserializationBenchmarkBase : BenchmarkBase
    {
        protected string bigObject, bigArray, realWorldObject;

        [GlobalSetup]
        public void Setup()
        {
            var bigJsonObject = GenerateObjects(3);
            bigObject = bigJsonObject.ToString();

            bigArray = @"
                [];
            ";

            realWorldObject = @"
                {
                    ""foo"": ""bar""
                }
            ";
        }

        public abstract void DeserializeBigObject();
        public abstract void DeserializeBigArray();
        public abstract void DeserializeRealWorldObject();
    }
}