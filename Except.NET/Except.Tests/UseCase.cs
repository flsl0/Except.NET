namespace System.Excepts.Tests;

public class DivisorCantBeZero() : Exception("Cannot divide by zero") { }

public class DefaultLabelNotFound() : Exception("No default label") { }

public class LabelNotFound() : Exception("No label found") { }

public class ApiNotNull() : Exception("The Api can't be null") { }

public class ApiNotExecuted() : Exception("The Api wasn't executed") { }

public class ResultNotCorrect() : Exception("The result of the calculation is not correct") { }

public class IncorrectType() : Exception("The checked type is incorrect") { }

internal class Lib
{
    public static string GetVersion() => throw new NotImplementedException("No version available");

    public static string GetVersion2() => throw new NotImplementedException("No version2 available");

    public static double Divide(double a, double b) => Except
        .Check<DivisorCantBeZero>(b != 0)
        .Do(() => a / b);

    public static double Divide2(double a, double b)
    {
        Except.Check<DivisorCantBeZero>(b != 0);

        return a / b;
    }

    public static Dictionary<string, int> GetDict() => new Dictionary<string, int>
    {
        { "toto", 0 },
        { "tata", 1 },
        { "tutu", 2 },
    };

    public static string GetLabel(string labelId) => labelId switch
    {
        "1" => "toto",
        "2" => "tutu",
        "3" => "tata",
        _ => throw new DefaultLabelNotFound()
    };

    public static string GetLabelById(int labelId) => labelId switch
    {
        1 => "toto",
        2 => "tutu",
        3 => throw new LabelNotFound(),
        _ => throw new DefaultLabelNotFound()
    };
}

public class Api
{
    private void HandleException(Exception ex) => Console.WriteLine(ex);

    private void HandleExceptions(List<Exception> list) => Console.WriteLine(list);

    public double Divide(double dividend, double divisor) => Except.Try(() => Lib.Divide(dividend, divisor))
        .Catch<DivisorCantBeZero>(double.PositiveInfinity);

    public string GetVersion() => Except.Try(Lib.GetVersion)
        .Catch(_ => "0.0.0-Dev");

    public List<string> GetLabelsByIds(int[] arr) => Except.ForEach(arr, Lib.GetLabelById)
        .CatchAll(HandleExceptions);

    public string GetLabelById(int labelId) => Except.Try(() => Lib.GetLabelById(labelId))
        .Catch<LabelNotFound>(Except.Throw)
        .Catch<DefaultLabelNotFound>(Except.Throw);

    public static Api CreateApi() => (Api) Except.Try(_CreateApi)
        .Catch<Exception>(new Api());

    private static Api _CreateApi() => new Api();

    public bool IsExecuted { get; set; }

    public void Execute() => IsExecuted = true;
}

public record Book
{
    public Book(string title, int isbn, List<string> authors)
    {
        title.Check<NotNull>();

        title.Check<NotBlank>();

        isbn.Check<NotNull>();

        authors.Check<NotNull>();

        authors.Check<NotEmpty>();
    }
}
