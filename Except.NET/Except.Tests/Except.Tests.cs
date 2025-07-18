using static System.Excepts.Except;

namespace System.Excepts.Tests;

public class TestApi
{
    private Api Api;

    public TestApi() => Api = new();

    [Fact]
    public void Test_Api_Divide() => Api.Divide(10, 2)
        .Check(r => r == 5, "10/2 should be 5");

    [Fact]
    public void Test_Api_Divide_Error() => Api.Divide(10, 0)
        .Check(r => r == double.PositiveInfinity, "10/0 should be PositiveInfinity (as per the function spec)");

    [Fact]
    public void Test_Api_GetVersion() => Api.GetVersion()
        .Check(v => v is string, $"GetVersion should always return a string even if it throws (as per the function spec)");

    [Fact]
    public void Test_Api_GetLabels() => Api.GetLabelsByIds(new[] {1, 2, 3, 4, 5 })
        .Check(r => r is not null, "GetLabels should return a non null list (as per the function spec)");

    [Fact]
    public void Test_Throw_LabelNotFound() => Assert.Throws<LabelNotFound>(() => Api.GetLabelById(3));

    [Fact]
    public void Test_Throw_DefaultLabelNotFound() => Assert.Throws<DefaultLabelNotFound>(() => Api.GetLabelById(0));

    [Fact]
    public void Test_Pass_Exception_As_Args_For_Obj() => Api.CreateApi()
        .Check<ApiNotNull>(api => api != null, "The api object shouldn't be null");

    [Fact]
    public void Test_Provided_Not_Null_Exception() => Api.CreateApi()
        .Check<NotNull>("The api object shouldn't be null");

    private object? NullObj = null;

    [Fact]
    public void Test_Provided_Check_Exception_Throws() => Assert.Throws<NotNull>(() => NullObj.Check<NotNull>());

    [Fact]
    public void Test_Custom_Provided_Check_Exception_Throws() => Assert.Throws<StrictlyPositive>(() => (0).Check<StrictlyPositive>());

    [Fact]
    public void Test_Void_Function_With_Do() => Do(Api.Execute)
        .Check(Api.IsExecuted, "`Do` should just execute a function so it can be chained");

    [Fact]
    public void Test_Void_Function_With_Run() => Run(Api.Execute)
        .Check(Api.IsExecuted, "`Run` should just execute a function so it can be chained");

    [Fact]
    public void Test_Void_Function_With_Try() => Try(Api.Execute)
        .Check(Api.IsExecuted, "`Try` should just execute a function in a try-catch context so it can be chained");

    [Fact]
    public void Test_Void_Function_With_Try_Catch() => Try(Api.Execute)
        .Catch(Console.WriteLine)
        .Check(Api.IsExecuted, "`Catch` should resolve to the correct catch function");

    [Fact]
    public void Test_Catch_And_Return_Single_Object() => Try(() => throw new Exception())
        .Catch<Exception>(new Api())
        .Catch<ArgumentNullException>(null)
        .Check(api => api != null, "Catch can also return a single object without using a lambda");

    [Fact]
    public void Test_Create_Book() => new Book("Title", 0, new List<string> { "Author" }).Check<NotNull>();

    [Fact]
    public void Test_Book_No_Title() => Assert.Throws<NotNull>(() => new Book(null, 0, new List<string> { "Author" }));

    [Fact]
    public void Test_Book_Blank_Title() => Assert.Throws<NotBlank>(() => new Book("", 0, new List<string> { "Author" }));

    [Fact]
    public void Test_Book_No_Authors() => Assert.Throws<NotNull>(() => new Book("Title", 0, null));

    [Fact]
    public void Test_Book_Empty_Authors() => Assert.Throws<NotEmpty>(() => new Book("Title", 0, new List<string>()));
}

public class TestTry
{
    [Fact]
    public void Test_Try_Divide() => Try(() => Lib.Divide(10, 2))
        .Check(r => r == 5, "10/2 should be 5 without handling any exceptions");

    [Fact]
    public void Test_Try_Divide_With_Params() => Try(Lib.Divide, 10.0, 2.0)
        .Check(r => r == 5, "10/2 should be 5 without handling any exceptions");

    [Fact]
    public void Test_Try_Catch_Divide() => Try(() => Lib.Divide(10, 2))
        .Catch(Console.WriteLine)
        .Check(r => r == 5, "10/2 should be 5");

    [Fact]
    public void Test_Divide_Error_Return_Default() => Try(() => Lib.Divide(10, 0))
        .Check(r => r == default(double), "10/0 should be default(double) without throwing any exceptions");

    public void Test_Divide_Error_Override_Return() => Try(() => Lib.Divide(10, 0))
        .Catch(_ => double.PositiveInfinity)
        .Check(r => r == double.PositiveInfinity, "10/0 could be Infinity");

    public void Test_Divide_Error_Override_Return_Wit_hNamed_Args() => Try(() => Lib.Divide(10, 0))
        .Catch<Exception>(@return: double.PositiveInfinity)
        .Check(r => r == double.PositiveInfinity, "10/0 could be Infinity");

    [Fact]
    public void Test_Multi_Catch() => Try(Lib.GetVersion)
        .Catch((NotImplementedException ex) => "1.0.0")
        .Catch((Exception ex) => "0.0.0")
        .Check(v => v == "1.0.0", "Only the correct exception should be handled in a multiple catch");

    [Fact]
    public void Test_Multi_Catch_With_Switch() => Try(Lib.GetVersion)
        .Catch(ex => { switch (ex)
        {
            case NotImplementedException n: return "1.0.0";
            case Exception e: return "0.0.0";
            default: return "0.0.0";
        }})
        .Check(v => v == "1.0.0", "Getting a NotImplementedException should return 1.0.0");

    [Fact]
    public void Test_Multi_Catch_With_Generics() => Try(Lib.GetVersion)
        .Catch<NotImplementedException>(_ => "1.0.0")
        .Catch<Exception>(_ => "0.0.0")
        .Check(v => v == "1.0.0", "Getting a NotImplementedException should return 1.0.0");

    [Fact]
    public void Test_Catch_With_No_Lambda() => Try(Lib.GetVersion)
        .Catch<NotImplementedException>("1.0.0")
        .Catch<Exception>("0.0.0")
        .Check(v => v == "1.0.0", "Getting a NotImplementedException should return 1.0.0");

    private string Result = "";

    private string Result2 = "";

    [Fact]
    public void Test_Try_Exception_With_Threads()
    {
        Parallel.Invoke(
            () => Try(Lib.GetVersion).Catch(ex => Result = ex.Message),
            () => Try(Lib.GetVersion2).Catch(ex => Result2 = ex.Message)
        );

        Check(Result != Result2, "Trying should be thread safe and handle different exceptions");
    }

    [Fact]
    public void Test_Default_Catch() => Try(Lib.GetVersion)
        .Catch((Exception ex) => "0.0.0")
        .Catch((NotImplementedException ex) => "1.0.0")
        .Check(v => v == "0.0.0", "The exception type should be the default catch (meaning all other catch will be ignored after)");

    [Fact]
    public void Test_Catch_Handle_Correct_Exception() => Try(Lib.GetVersion)
        .Catch<ArgumentNullException>("0.0.0")
        .Catch<NotImplementedException>("1.0.0")
        .Catch<Exception>("0.0.0")
        .Check(v => v == "1.0.0", $"Getting a NotImplementedException should return 1.0.0");

    [Fact]
    public void Test_Nested_Try() => Try(() => Try(() => throw new Exception()))
        .Catch(Throw)
        .Check(true, "Catch should only handle exception at its stack level");

    [Fact]
    public void Test_Nested_Try_With_Throw() => Assert.Throws<ArgumentNullException>(() => Try(() => 
        {
            Try(() => throw new Exception());

            throw new ArgumentNullException();
        })
        .Catch(Throw));

    [Fact]
    public void Test_Explicit_Ignore_Exception() => Try(() =>
        {
            Try(() => throw new Exception()).Catch();

            Try(() => throw new ArgumentNullException())
                .Catch(e => Check(e is ArgumentNullException));
        });

    [Fact]
    public void Test_No_Explicit_Ignore_Exception() => Try(() =>
        {
            Try(() => throw new Exception());

            Try(() => 1 + 1)
                .Catch(_ => Check(false)); // This function is not executed
        })
        .Catch(Throw);

    [Fact]
    public void Test_Null_Coercion() => (Try<double?>(() => Lib.Divide(1, 0)) ?? double.PositiveInfinity)
        .Check(r => r == double.PositiveInfinity);

    [Fact]
    public void Test_Chain_Run() => Run(() => {}).Run(() => {});

    [Fact]
    public void Test_Chain_Run_With_Params() => Run(Lib.Divide, 10.0, 2.0).Run(Lib.Divide, 20.0, 2.0)
        .Check(r => r == 10);

    [Fact]
    public void Test_Chain_Run_With_Params_With_Source() => Run(Lib.Divide, 10.0, 2.0).Run(Lib.Divide, 20.0)
        .Check(r => r == 4);

    [Fact]
    public void Test_Chain_Run_With_Params2() => Run(Lib.Divide, 10.0, 2.0)
        .Check(r => r == 5);

    [Fact]
    public void Test_Piping_Via_Run() => "Hello".Run(s => s + " ").Run(s => s + "World")
        .Check(s => s == "Hello World");
}

public class TestForEach
{
    private List<int> GetListInt(List<int> list) => list;

    private List<int> GetList() => ForEach(new List<int> { 1, 2, 3, 4 }, i => GetListInt(i));

    [Fact]
    public void Test_ForEach_Range() => GetList()
        .Check(list => list.Count == 16, "ForEach should handle range and concat list");

    private List<Exception> Exceptions = new();

    [Fact]
    public void Test_ForEach_CatchAll() => ForEach(new[] { 1, 2, 3 }, _ => throw new Exception())
        .CatchAll(Exceptions.AddRange)
        .Check(Exceptions.GetCountAndClear() > 0, "The list of exceptions shouldn't be empty after catching them all");

    [Fact]
    public void Test_ForEach_Get() => ForEach(new[] { "1", "2", "3", "4" }, Lib.GetLabel)
        .CatchAll(Exceptions.AddRange)
        .Check(r => r.Count > 0, "The list of result shouldn't be empty after getting them all")
        .Check(Exceptions.GetCountAndClear() > 0, "The list of exceptions shouldn't be empty after catching them all");

    [Fact]
    public void Test_ForEach_GetById() => ForEach(new[] { 1, 2, 3, 4 }, Lib.GetLabelById)
        .CatchAll(Exceptions.AddRange)
        .Check(r => r.Count > 0, "The list of result shouldn't be empty after getting them all")
        .Check(Exceptions.GetCountAndClear() > 0, "The list of exceptions shouldn't be empty after catching them all");

    List<int> ArrayOfInt = [1, 2, 3, 4, 5, 6];

    [Fact]
    public void Test_ForEach_Try_With_Linq() => ArrayOfInt
        .Where(i => i % 2 == 0)
        .ForEachTry(_ => throw new Exception())
        .CatchAll(Exceptions.AddRange)
        .Check(Exceptions.GetCountAndClear() > 0, "The list of exceptions shouldn't be empty after catching them all");

    [Fact]
    public void Test_Parallel_ForEach_Try() => ArrayOfInt
        .ParallelForEachTry(_ => throw new Exception())
        .CatchAll(Exceptions.AddRange)
        .Check(Exceptions.GetCountAndClear() > 0, "ParallelForEachTry should execute in parallel but handle exception in sync");
}

public class TestCheck
{
    [Fact]
    public void Test_Do_And_Check() => Lib.Divide(10, 2)
        .Check(r => r == 5)
        .Do(r => r * 2)
        .Check(r => r == 10, "10/2 should be equal to 5 times 2 should be equal to 10");

    [Fact]
    public void Test_Pass_Exception_As_Args() => Lib.Divide(10, 2)
        .Check<ResultNotCorrect>(res => res == 5)
        .Check(r => r > 0)
        .Check(r => r == 5, "10/2 should be equal to 5");

    [Fact]
    public void Test_Multiple_Check_For_Object() => Api.CreateApi()
        .Check<ApiNotNull>(api => api != null)
        .Check(true)
        .Check(api => api != null, "The api object shouldn't be null");

    [Fact]
    public void Test_Check_With_Dictionary() => Lib.GetDict()
        .Check(d => d is IDictionary<string, int>, "Check should work with dictionary");

    [Fact]
    public void Test_Check_With_Dictionary_With_Args() => Lib.GetDict()
        .Check<IncorrectType>(d => d is IDictionary<string, int>);

    [Fact]
    public void Test_Check_Error() => Assert.Throws<Exception>(() => Lib.Divide(10, 2).Check(res => res == 0));

    [Fact]
    public void Test_Check_Throws() => Assert.Throws<Exception>(() => Check(false));
}

public static class TestUtils
{
    public static int GetCountAndClear(this List<Exception> list)
    {
        var count = list.Count;

        list.Clear();

        return count;
    }
}
