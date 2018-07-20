# JSONParsComp

This project contains the code for OTH Regensburg's Software Reliability and Performance course by Prof. Dr. Richard Lipka.

The main task for this course was, to test and benchmark different software frameworks. This repo contains benchmarks for two different JSON (de-)serialization libraries, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) and [System.Json](https://www.nuget.org/packages/System.Json), both benchmarked using dotnet's [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library.


## Usage

This project was built on dotnet core, so make sure to have its binaries in your path.

After everything's set up, make sure your computer is idle. Then run the following commands on your terminal:

```bash
# restore the packages required for the build
$ dotnet restore

# build the project in release mode
$ dotnet build -c Release

# execute the benchmark
$ dotnet run
```


## License

The coude in in this repo is purely educational and thus licensed under the [GPLv3](LICENSE).
