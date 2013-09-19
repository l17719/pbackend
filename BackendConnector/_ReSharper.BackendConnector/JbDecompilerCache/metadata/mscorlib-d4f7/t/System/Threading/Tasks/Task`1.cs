// Type: System.Threading.Tasks.Task`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;

namespace System.Threading.Tasks
{
    [DebuggerTypeProxy(typeof (SystemThreadingTasks_FutureDebugView<>))]
    [DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true, Synchronization = true)]
    public class Task<TResult> : Task
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<TResult> function);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<TResult> function, CancellationToken cancellationToken);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<TResult> function, TaskCreationOptions creationOptions);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<object, TResult> function, object state);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<object, TResult> function, object state, TaskCreationOptions creationOptions);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task<TResult>> continuationAction);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public TResult Result { get; internal set; }

        public new static TaskFactory<TResult> Factory { get; }
    }
}
