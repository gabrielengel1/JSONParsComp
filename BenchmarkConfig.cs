using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Validators;

namespace JSONParsComp
{
    internal sealed class BenchmarkConfig : ManualConfig
    {
        public void AllowNonOptimized()
        {
            Add(JitOptimizationsValidator.DontFailOnError);

            Add(DefaultConfig.Instance.GetLoggers().ToArray());
            Add(DefaultConfig.Instance.GetExporters().ToArray());
            Add(DefaultConfig.Instance.GetColumnProviders().ToArray());
        }
    }
}