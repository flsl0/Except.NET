using System.Threading;
using System.Collections.Generic;

namespace System.Excepts
{
    public partial class Except
    {
        private static int ThreadId => Thread.CurrentThread.ManagedThreadId;

        private static Dictionary<int, Exception> ThreadIdToException = new Dictionary<int, Exception>();

        private static Dictionary<int, List<Exception>> ThreadIdToExceptions = new Dictionary<int, List<Exception>>();
    }

    public abstract class CheckException : Exception
    {
        public abstract dynamic ToTest { get; set; }

        public abstract bool Test();

        public new string Message;
    }

    public class NotNull : CheckException
    {
        public override dynamic ToTest { get; set; }

        public override bool Test() => ToTest != null;

        public string Message = "The object is null";
    }

    public class StrictlyPositive : CheckException
    {
        public override dynamic ToTest { get; set; }

        public override bool Test() => ToTest > 0;

        public string Message = "The value is not strictly positive";
    }
}
