using System.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace JSONParsComp
{
    [MemoryDiagnoser]
    [CoreJob(isBaseline: true)]
    public abstract class BenchmarkBase
    {
        protected JsonValue GenerateObjects(int n)
        {
            if (n < 1)
            {
                return new JsonPrimitive(1);
            }
            
            var obj = new JsonObject();

            for (int i = 0; i < n; i++)
            {
                obj[$"{i}"] = GenerateObjects(i - 1);
            }

            return obj;
        }

        protected JsonArray GenerateArray(int n)
        {
            var array = new JsonArray();
            
            for (int i = 0; i < n; i++)
            {
                array.Add(GenerateObjects(i));
            }

            return array;
        }
    }
}