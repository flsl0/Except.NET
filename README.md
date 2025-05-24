# Except.NET

Except.NET is a library that uses a fluent interface and lambda expression to improve the handling of exception.

## Usage
You can check `Except.NET/Except.Tests/UseCase.cs` and `Except.NET/Except.Tests/Except.Tests.cs` for more example but here is a quick overview :
```C#
using static System.Excepts.Except;

Dictionary<string, int> dict = new()
{
    { "toto", 0 },
    { "tata", 1 },
    { "tutu", 2 },
};

int val = Try(() => dict["toto"]); // easy way to lookup index in Dictionary

int val2 = Try(() => dict["titi"]); // will simply return default in case of non existing index

double Divide(double a, double b)
{
    Check(b != 0); // will throw an exception if b == 0

    return a / b;
}

double result = Try(() => Divide(1, 0)).Catch<Exception>(double.PositiveInfinity); // return double.PositiveInfinity in case of an exception

double result2 = Try(Divide, 1, 0).Catch<Exception>(double.PositiveInfinity); // Use try without using a closure
```