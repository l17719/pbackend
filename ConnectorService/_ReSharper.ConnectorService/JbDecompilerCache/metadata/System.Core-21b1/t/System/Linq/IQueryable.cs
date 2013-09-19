// Type: System.Linq.IQueryable
// Assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Core.dll

using System;
using System.Collections;
using System.Linq.Expressions;

namespace System.Linq
{
    /// <summary>
    /// Provides functionality to evaluate queries against a specific data source wherein the type of the data is not specified.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    [__DynamicallyInvokable]
    public interface IQueryable : IEnumerable
    {
        /// <summary>
        /// Gets the expression tree that is associated with the instance of <see cref="T:System.Linq.IQueryable"/>.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.Expressions.Expression"/> that is associated with this instance of <see cref="T:System.Linq.IQueryable"/>.
        /// </returns>
        [__DynamicallyInvokable]
        Expression Expression { [__DynamicallyInvokable]
        get; }

        /// <summary>
        /// Gets the type of the element(s) that are returned when the expression tree associated with this instance of <see cref="T:System.Linq.IQueryable"/> is executed.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Type"/> that represents the type of the element(s) that are returned when the expression tree associated with this object is executed.
        /// </returns>
        [__DynamicallyInvokable]
        Type ElementType { [__DynamicallyInvokable]
        get; }

        /// <summary>
        /// Gets the query provider that is associated with this data source.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.IQueryProvider"/> that is associated with this data source.
        /// </returns>
        [__DynamicallyInvokable]
        IQueryProvider Provider { [__DynamicallyInvokable]
        get; }
    }
}
