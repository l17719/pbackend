// Type: Caliburn.Micro.Coroutine
// Assembly: Caliburn.Micro, Version=1.3.1.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f
// Assembly location: C:\Users\joao\Documents\Visual Studio 2010\Projects\BackEndAplication\BackEndAplication\Lib\Caliburn.Micro.dll

using System;
using System.Collections.Generic;

namespace Caliburn.Micro
{
    /// <summary>
    /// Manages coroutine execution.
    /// 
    /// </summary>
    public static class Coroutine
    {
        /// <summary>
        /// Creates the parent enumerator.
        /// 
        /// </summary>
        public static Func<IEnumerator<IResult>, IResult> CreateParentEnumerator;

        /// <summary>
        /// Executes a coroutine.
        /// 
        /// </summary>
        /// <param name="coroutine">The coroutine to execute.</param><param name="context">The context to execute the coroutine within.</param>/// <param name="callback">The completion callback for the coroutine.</param>
        public static void BeginExecute(IEnumerator<IResult> coroutine, ActionExecutionContext context = null, EventHandler<ResultCompletionEventArgs> callback = null);

        /// <summary>
        /// Called upon completion of a coroutine.
        /// 
        /// </summary>
        public static event EventHandler<ResultCompletionEventArgs> Completed;
    }
}
