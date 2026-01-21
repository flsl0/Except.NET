using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace System.Excepts
{
    public partial class Except
    {
        private static int FrameCount => new StackTrace(true).FrameCount;

        private static int ThreadId => Thread.CurrentThread.ManagedThreadId + FrameCount;

        private static IDictionary<int, Exception> ThreadIdToException = new ConcurrentDictionary<int, Exception>();

        private static IDictionary<int, List<Exception>> ThreadIdToExceptions = new ConcurrentDictionary<int, List<Exception>>();
    }
}