namespace JSONParsComp.SerializationBenchmark
{
    public abstract class SerializationBenchmarkBase : BenchmarkBase
    {
        public abstract void SerializeBigObject();
        public abstract void SerializeBigArray();
        public abstract void SerializeRealWorldObject();
    }
}