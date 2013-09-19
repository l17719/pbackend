// Type: System.Collections.Generic.IEnumerable`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Collections;

namespace System.Collections.Generic
{
    /// <summary>
    /// Exposes the enumerator, which supports a simple iteration over a collection of a specified type.
    /// 
    /// </summary>
    /// <typeparam name="T">The type of objects to enumerate.
    ///                 </typeparam><filterpriority>1</filterpriority>
    public interface IEnumerable<out T> : IEnumerable
    {
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        /// 
        /// </returns>
        /// <filterpriority>1</filterpriority>
        new IEnumerator<T> GetEnumerator();
    }
}
