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

double result2 = Try(Divide, 1.0, 0.0); // Use try without using a closure

double result3 = Try(Divide, 1.0, 0.0).Catch<Exception>(double.PositiveInfinity);

double result4 = Try(Divide, 1.0, 0.0) // Multiple catch handling by chaining catch methods
    .Catch<NotImplementedException>(double.PositiveInfinity)
    .Catch<Exception>(double.PositiveInfinity);

double result5 = Try(Divide, 1.0, 0.0).Catch(e => e switch // Multiple catch handling by using switch expression
{
    NotImplementedException ex => double.PositiveInfinity,
    Exception ex => double.PositiveInfinity,
    _ => double.PositiveInfinity
});

AnObject anObject = Try(AnObject.Create).Catch(_ => new AnObject());

AnObject anObjectFromString = Try(AnObject.From, "a string").Catch(_ => new AnObject());

FileStream fs = Try(File.Open, "test.txt", FileMode.Open, FileAccess.Read, FileShare.None);

class AnObject
{
    public static AnObject Create() => throw new Exception();

    public static AnObject From(string str) => throw new Exception();
}
```
