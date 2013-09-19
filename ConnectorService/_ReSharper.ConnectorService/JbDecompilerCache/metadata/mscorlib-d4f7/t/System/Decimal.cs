// Type: System.Decimal
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Globalization;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
    /// <summary>
    /// Represents a decimal number.
    /// 
    /// </summary>
    /// <filterpriority>1</filterpriority>
    [ComVisible(true)]
    [__DynamicallyInvokable]
    [Serializable]
    public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<decimal>, IEquatable<decimal>
    {
        /// <summary>
        /// Represents the number zero (0).
        /// 
        /// </summary>
        /// <filterpriority>1</filterpriority>
        [__DynamicallyInvokable] public const decimal Zero = 0;

        /// <summary>
        /// Represents the number one (1).
        /// 
        /// </summary>
        /// <filterpriority>1</filterpriority>
        [__DynamicallyInvokable] public const decimal One = 1;

        /// <summary>
        /// Represents the number negative one (-1).
        /// 
        /// </summary>
        /// <filterpriority>1</filterpriority>
        [__DynamicallyInvokable] public const decimal MinusOne = -1;

        /// <summary>
        /// Represents the largest possible value of <see cref="T:System.Decimal"/>. This field is constant and read-only.
        /// 
        /// </summary>
        /// <filterpriority>1</filterpriority>
        [__DynamicallyInvokable] public const decimal MaxValue = 79228162514264337593543950335;

        /// <summary>
        /// Represents the smallest possible value of <see cref="T:System.Decimal"/>. This field is constant and read-only.
        /// 
        /// </summary>
        /// <filterpriority>1</filterpriority>
        [__DynamicallyInvokable] public const decimal MinValue = -79228162514264337593543950335;

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> to the value of the specified 32-bit signed integer.
        /// 
        /// </summary>
        /// <param name="value">The value to represent as a <see cref="T:System.Decimal"/>.
        ///                 </param>
        [__DynamicallyInvokable]
        public Decimal(int value);

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> to the value of the specified 32-bit unsigned integer.
        /// 
        /// </summary>
        /// <param name="value">The value to represent as a <see cref="T:System.Decimal"/>.
        ///                 </param>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public Decimal(uint value);

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> to the value of the specified 64-bit signed integer.
        /// 
        /// </summary>
        /// <param name="value">The value to represent as a <see cref="T:System.Decimal"/>.
        ///                 </param>
        [__DynamicallyInvokable]
        public Decimal(long value);

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> to the value of the specified 64-bit unsigned integer.
        /// 
        /// </summary>
        /// <param name="value">The value to represent as a <see cref="T:System.Decimal"/>.
        ///                 </param>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public Decimal(ulong value);

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> to the value of the specified single-precision floating-point number.
        /// 
        /// </summary>
        /// <param name="value">The value to represent as a <see cref="T:System.Decimal"/>.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Decimal.MaxValue"/> or less than <see cref="F:System.Decimal.MinValue"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is <see cref="F:System.Single.NaN"/>, <see cref="F:System.Single.PositiveInfinity"/>, or <see cref="F:System.Single.NegativeInfinity"/>.
        ///                 </exception>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public Decimal(float value);

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> to the value of the specified double-precision floating-point number.
        /// 
        /// </summary>
        /// <param name="value">The value to represent as a <see cref="T:System.Decimal"/>.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.Decimal.MaxValue"/> or less than <see cref="F:System.Decimal.MinValue"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is <see cref="F:System.Double.NaN"/>, <see cref="F:System.Double.PositiveInfinity"/>, or <see cref="F:System.Double.NegativeInfinity"/>.
        ///                 </exception>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public Decimal(double value);

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> to a decimal value represented in binary and contained in a specified array.
        /// 
        /// </summary>
        /// <param name="bits">An array of 32-bit signed integers containing a representation of a decimal value.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="bits"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentException">The length of the <paramref name="bits"/> is not 4.
        /// 
        ///                     -or-
        /// 
        ///                     The representation of the decimal value in <paramref name="bits"/> is not valid.
        ///                 </exception>
        [__DynamicallyInvokable]
        public Decimal(int[] bits);

        /// <summary>
        /// Initializes a new instance of <see cref="T:System.Decimal"/> from parameters specifying the instance's constituent parts.
        /// 
        /// </summary>
        /// <param name="lo">The low 32 bits of a 96-bit integer.
        ///                 </param><param name="mid">The middle 32 bits of a 96-bit integer.
        ///                 </param><param name="hi">The high 32 bits of a 96-bit integer.
        ///                 </param><param name="isNegative">The sign of the number; 1 is negative, 0 is positive.
        ///                 </param><param name="scale">A power of 10 ranging from 0 to 28.
        ///                 </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="scale"/> is greater than 28.
        ///                 </exception>
        [__DynamicallyInvokable]
        public Decimal(int lo, int mid, int hi, bool isNegative, byte scale);

        /// <summary>
        /// Converts an 8-bit unsigned integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 8-bit unsigned integer.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit unsigned integer.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static implicit operator decimal(byte value);

        /// <summary>
        /// Converts an 8-bit signed integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 8-bit signed integer.
        /// 
        /// </returns>
        /// <param name="value">An 8-bit signed integer.
        ///                 </param><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static implicit operator decimal(sbyte value);

        /// <summary>
        /// Converts a 16-bit signed integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 16-bit signed integer.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit signed integer.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static implicit operator decimal(short value);

        /// <summary>
        /// Converts a 16-bit unsigned integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 16-bit unsigned integer.
        /// 
        /// </returns>
        /// <param name="value">A 16-bit unsigned integer.
        ///                 </param><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static implicit operator decimal(ushort value);

        /// <summary>
        /// Converts a Unicode character to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted Unicode character.
        /// 
        /// </returns>
        /// <param name="value">A Unicode character.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static implicit operator decimal(char value);

        /// <summary>
        /// Converts a 32-bit signed integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 32-bit signed integer.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit signed integer.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static implicit operator decimal(int value);

        /// <summary>
        /// Converts a 32-bit unsigned integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 32-bit unsigned integer.
        /// 
        /// </returns>
        /// <param name="value">A 32-bit unsigned integer.
        ///                 </param><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static implicit operator decimal(uint value);

        /// <summary>
        /// Converts a 64-bit signed integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 64-bit signed integer.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit signed integer.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static implicit operator decimal(long value);

        /// <summary>
        /// Converts a 64-bit unsigned integer to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted 64-bit unsigned integer.
        /// 
        /// </returns>
        /// <param name="value">A 64-bit unsigned integer.
        ///                 </param><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static implicit operator decimal(ulong value);

        /// <summary>
        /// Converts a single-precision floating-point number to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted single-precision floating point number.
        /// 
        /// </returns>
        /// <param name="value">A single-precision floating-point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is <see cref="F:System.Single.NaN"/>, <see cref="F:System.Single.PositiveInfinity"/>, or <see cref="F:System.Single.NegativeInfinity"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static explicit operator decimal(float value);

        /// <summary>
        /// Converts a double-precision floating-point number to a <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that represents the converted double-precision floating point number.
        /// 
        /// </returns>
        /// <param name="value">A double-precision floating-point number.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is <see cref="F:System.Double.NaN"/>, <see cref="F:System.Double.PositiveInfinity"/>, or <see cref="F:System.Double.NegativeInfinity"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static explicit operator decimal(double value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to an 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator byte(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to an 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.SByte.MinValue"/> or greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator sbyte(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a Unicode character.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A Unicode character that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static explicit operator char(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator short(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.UInt16.MaxValue"/> or less than <see cref="F:System.UInt16.MinValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator ushort(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Int32.MinValue"/> or greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator int(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is negative or greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator uint(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Int64.MinValue"/> or greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator long(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit unsigned integer that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is negative or greater than <see cref="F:System.UInt64.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator ulong(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a single-precision floating-point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating-point number that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator float(decimal value);

        /// <summary>
        /// Converts a <see cref="T:System.Decimal"/> to a double-precision floating-point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating-point number that represents the converted <see cref="T:System.Decimal"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> to convert.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static explicit operator double(decimal value);

        /// <summary>
        /// Returns the value of the <see cref="T:System.Decimal"/> operand (the sign of the operand is unchanged).
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the operand, <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">The <see cref="T:System.Decimal"/> operand.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static decimal operator +(decimal d);

        /// <summary>
        /// Negates the value of the specified <see cref="T:System.Decimal"/> operand.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The result of <paramref name="d"/> multiplied by negative one (-1).
        /// 
        /// </returns>
        /// <param name="d">The <see cref="T:System.Decimal"/> operand.
        ///                 </param><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static decimal operator -(decimal d);

        /// <summary>
        /// Increments the <see cref="T:System.Decimal"/> operand by 1.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of <paramref name="d"/> incremented by 1.
        /// 
        /// </returns>
        /// <param name="d">The <see cref="T:System.Decimal"/> operand.
        ///                 </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static decimal operator ++(decimal d);

        /// <summary>
        /// Decrements the <see cref="T:System.Decimal"/> operand by one.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of <paramref name="d"/> decremented by 1.
        /// 
        /// </returns>
        /// <param name="d">The <see cref="T:System.Decimal"/> operand.
        ///                 </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        public static decimal operator --(decimal d);

        /// <summary>
        /// Adds two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> result of adding <paramref name="d1"/> and <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal operator +(decimal d1, decimal d2);

        /// <summary>
        /// Subtracts two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> result of subtracting <paramref name="d2"/> from <paramref name="d1"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal operator -(decimal d1, decimal d2);

        /// <summary>
        /// Multiplies two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> result of multiplying <paramref name="d1"/> by <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal operator *(decimal d1, decimal d2);

        /// <summary>
        /// Divides two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> result of <paramref name="d1"/> by <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/> (the dividend).
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/> (the divisor).
        ///                 </param><exception cref="T:System.DivideByZeroException"><paramref name="d2"/> is zero.
        ///                 </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal operator /(decimal d1, decimal d2);

        /// <summary>
        /// Returns the remainder resulting from dividing two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> remainder resulting from dividing <paramref name="d1"/> by <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/> (the dividend).
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/> (the divisor).
        ///                 </param><exception cref="T:System.DivideByZeroException"><paramref name="d2"/> is zero.
        ///                 </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>3</filterpriority>
        [__DynamicallyInvokable]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static decimal operator %(decimal d1, decimal d2);

        /// <summary>
        /// Returns a value indicating whether two instances of <see cref="T:System.Decimal"/> are equal.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="d1"/> and <paramref name="d2"/> are equal; otherwise, false.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static bool operator ==(decimal d1, decimal d2);

        /// <summary>
        /// Returns a value indicating whether two instances of <see cref="T:System.Decimal"/> are not equal.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="d1"/> and <paramref name="d2"/> are not equal; otherwise, false.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static bool operator !=(decimal d1, decimal d2);

        /// <summary>
        /// Returns a value indicating whether a specified <see cref="T:System.Decimal"/> is less than another specified <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="d1"/> is less than <paramref name="d2"/>; otherwise, false.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static bool operator <(decimal d1, decimal d2);

        /// <summary>
        /// Returns a value indicating whether a specified <see cref="T:System.Decimal"/> is less than or equal to another specified <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="d1"/> is less than or equal to <paramref name="d2"/>; otherwise, false.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static bool operator <=(decimal d1, decimal d2);

        /// <summary>
        /// Returns a value indicating whether a specified <see cref="T:System.Decimal"/> is greater than another specified <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="d1"/> is greater than <paramref name="d2"/>; otherwise, false.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static bool operator >(decimal d1, decimal d2);

        /// <summary>
        /// Returns a value indicating whether a specified <see cref="T:System.Decimal"/> is greater than or equal to another specified <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="d1"/> is greater than or equal to <paramref name="d2"/>; otherwise, false.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>3</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static bool operator >=(decimal d1, decimal d2);

        /// <summary>
        /// Converts the specified <see cref="T:System.Decimal"/> value to the equivalent OLE Automation Currency value, which is contained in a 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer that contains the OLE Automation equivalent of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> value.
        ///                 </param><filterpriority>2</filterpriority>
        [__DynamicallyInvokable]
        public static long ToOACurrency(decimal value);

        /// <summary>
        /// Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the equivalent <see cref="T:System.Decimal"/> value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that contains the equivalent of <paramref name="cy"/>.
        /// 
        /// </returns>
        /// <param name="cy">An OLE Automation Currency value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal FromOACurrency(long cy);

        void IDeserializationCallback.OnDeserialization(object sender);

        /// <summary>
        /// Adds two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> value that is the sum of <paramref name="d1"/> and <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><exception cref="T:System.OverflowException">The sum of <paramref name="d1"/> and <paramref name="d2"/> is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal Add(decimal d1, decimal d2);

        /// <summary>
        /// Returns the smallest integer greater than or equal to the specified decimal number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The smallest integer greater than or equal to the <paramref name="d"/> parameter.
        /// 
        /// </returns>
        /// <param name="d">A decimal number.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal Ceiling(decimal d);

        /// <summary>
        /// Compares two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A signed number indicating the relative values of <paramref name="d1"/> and <paramref name="d2"/>.
        /// 
        ///                     Return Value
        /// 
        ///                     Meaning
        /// 
        ///                     Less than zero
        ///                 <paramref name="d1"/> is less than <paramref name="d2"/>.
        /// 
        ///                     Zero
        ///                 <paramref name="d1"/> and <paramref name="d2"/> are equal.
        /// 
        ///                     Greater than zero
        ///                 <paramref name="d1"/> is greater than <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>1</filterpriority>
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static int Compare(decimal d1, decimal d2);

        /// <summary>
        /// Compares this instance to a specified <see cref="T:System.Object"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A signed number indicating the relative values of this instance and <paramref name="value"/>.
        /// 
        ///                     Return Value
        /// 
        ///                     Meaning
        /// 
        ///                     Less than zero
        /// 
        ///                     This instance is less than <paramref name="value"/>.
        /// 
        ///                     Zero
        /// 
        ///                     This instance is equal to <paramref name="value"/>.
        /// 
        ///                     Greater than zero
        /// 
        ///                     This instance is greater than <paramref name="value"/>.
        /// 
        ///                     -or-
        ///                 <paramref name="value"/> is null.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> or null.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="value"/> is not a <see cref="T:System.Decimal"/>.
        ///                 </exception><filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        public int CompareTo(object value);

        /// <summary>
        /// Compares this instance to a specified <see cref="T:System.Decimal"/> object.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A signed number indicating the relative values of this instance and <paramref name="value"/>.
        /// 
        ///                     Return Value
        /// 
        ///                     Meaning
        /// 
        ///                     Less than zero
        /// 
        ///                     This instance is less than <paramref name="value"/>.
        /// 
        ///                     Zero
        /// 
        ///                     This instance is equal to <paramref name="value"/>.
        /// 
        ///                     Greater than zero
        /// 
        ///                     This instance is greater than <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> object.
        ///                 </param><filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public int CompareTo(decimal value);

        /// <summary>
        /// Divides two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> that is the result of dividing <paramref name="d1"/> by <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/> (the dividend).
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/> (the divisor).
        ///                 </param><exception cref="T:System.DivideByZeroException"><paramref name="d2"/> is zero.
        ///                 </exception><exception cref="T:System.OverflowException">The return value (that is, the quotient) is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal Divide(decimal d1, decimal d2);

        /// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="T:System.Object"/> represent the same type and value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is a <see cref="T:System.Decimal"/> and equal to this instance; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/>.
        ///                 </param><filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public override bool Equals(object value);

        /// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="T:System.Decimal"/> object represent the same value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="value"/> is equal to this instance; otherwise, false.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> object to compare to this instance.
        ///                 </param><filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public bool Equals(decimal value);

        /// <summary>
        /// Returns the hash code for this instance.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer hash code.
        /// 
        /// </returns>
        /// <filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public override int GetHashCode();

        /// <summary>
        /// Returns a value indicating whether two specified instances of <see cref="T:System.Decimal"/> represent the same value.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="d1"/> and <paramref name="d2"/> are equal; otherwise, false.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/>.
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static bool Equals(decimal d1, decimal d2);

        /// <summary>
        /// Rounds a specified <see cref="T:System.Decimal"/> number to the closest integer toward negative infinity.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// If <paramref name="d"/> has a fractional part, the next whole <see cref="T:System.Decimal"/> number toward negative infinity that is less than <paramref name="d"/>.
        /// 
        ///                     -or-
        /// 
        ///                     If <paramref name="d"/> doesn't have a fractional part, <paramref name="d"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal Floor(decimal d);

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A string that represents the value of this instance.
        /// 
        /// </returns>
        /// <filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public override string ToString();

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation, using the specified format.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The string representation of the value of this instance as specified by <paramref name="format"/>.
        /// 
        /// </returns>
        /// <param name="format">A numeric format string.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="format"/> is invalid.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public string ToString(string format);

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The string representation of the value of this instance as specified by <paramref name="provider"/>.
        /// 
        /// </returns>
        /// <param name="provider">An <see cref="T:System.IFormatProvider"/> that supplies culture-specific formatting information.
        ///                 </param><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public string ToString(IFormatProvider provider);

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The string representation of the value of this instance as specified by <paramref name="format"/> and <paramref name="provider"/>.
        /// 
        /// </returns>
        /// <param name="format">A numeric format string.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> that supplies culture-specific formatting information.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="format"/> is invalid.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public string ToString(string format, IFormatProvider provider);

        /// <summary>
        /// Converts the string representation of a number to its <see cref="T:System.Decimal"/> equivalent.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> number equivalent to the number contained in <paramref name="s"/>.
        /// 
        /// </returns>
        /// <param name="s">The string representation of the number to convert.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="s"/> is not in the correct format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="s"/> represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal Parse(string s);

        /// <summary>
        /// Converts the string representation of a number in a specified style to its <see cref="T:System.Decimal"/> equivalent.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> number equivalent to the number contained in <paramref name="s"/> as specified by <paramref name="style"/>.
        /// 
        /// </returns>
        /// <param name="s">The string representation of the number to convert.
        ///                 </param><param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles"/> values that indicates the style elements that can be present in <paramref name="s"/>. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number"/>.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="style"/> is not a <see cref="T:System.Globalization.NumberStyles"/> value.
        /// 
        ///                     -or-
        ///                 <paramref name="style"/> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier"/> value.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="s"/> is not in the correct format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="s"/> represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/></exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal Parse(string s, NumberStyles style);

        /// <summary>
        /// Converts the string representation of a number to its <see cref="T:System.Decimal"/> equivalent using the specified culture-specific format information.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> number equivalent to the number contained in <paramref name="s"/> as specified by <paramref name="provider"/>.
        /// 
        /// </returns>
        /// <param name="s">The string representation of the number to convert.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> that supplies culture-specific parsing information about <paramref name="s"/>.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null.
        ///                 </exception><exception cref="T:System.FormatException"><paramref name="s"/> is not of the correct format
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="s"/> represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/></exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal Parse(string s, IFormatProvider provider);

        /// <summary>
        /// Converts the string representation of a number to its <see cref="T:System.Decimal"/> equivalent using the specified style and culture-specific format.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> number equivalent to the number contained in <paramref name="s"/> as specified by <paramref name="style"/> and <paramref name="provider"/>.
        /// 
        /// </returns>
        /// <param name="s">The string representation of the number to convert.
        ///                 </param><param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles"/> values that indicates the style elements that can be present in <paramref name="s"/>. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number"/>.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> object that supplies culture-specific information about the format of <paramref name="s"/>.
        ///                 </param><exception cref="T:System.FormatException"><paramref name="s"/> is not in the correct format.
        ///                 </exception><exception cref="T:System.OverflowException"><paramref name="s"/> represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="style"/> is not a <see cref="T:System.Globalization.NumberStyles"/> value.
        /// 
        ///                     -or-
        ///                 <paramref name="style"/> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier"/> value.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal Parse(string s, NumberStyles style, IFormatProvider provider);

        /// <summary>
        /// Converts the string representation of a number to its <see cref="T:System.Decimal"/> equivalent. A return value indicates whether the conversion succeeded or failed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="s"/> was converted successfully; otherwise, false.
        /// 
        /// </returns>
        /// <param name="s">The string representation of the number to convert.
        ///                 </param><param name="result">When this method returns, contains the <see cref="T:System.Decimal"/> number that is equivalent to the numeric value contained in <paramref name="s"/>, if the conversion succeeded, or is zero if the conversion failed. The conversion fails if the <paramref name="s"/> parameter is null, is not a number in a valid format, or represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>. This parameter is passed uninitialized.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool TryParse(string s, out decimal result);

        /// <summary>
        /// Converts the string representation of a number to its <see cref="T:System.Decimal"/> equivalent using the specified style and culture-specific format. A return value indicates whether the conversion succeeded or failed.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="s"/> was converted successfully; otherwise, false.
        /// 
        /// </returns>
        /// <param name="s">The string representation of the number to convert.
        ///                 </param><param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles"/> values that indicates the permitted format of <paramref name="s"/>. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number"/>.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> object that supplies culture-specific parsing information about <paramref name="s"/>.
        ///                 </param><param name="result">When this method returns, contains the <see cref="T:System.Decimal"/> number that is equivalent to the numeric value contained in <paramref name="s"/>, if the conversion succeeded, or is zero if the conversion failed. The conversion fails if the <paramref name="s"/> parameter is null, is not in a format compliant with <paramref name="style"/>, or represents a number less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>. This parameter is passed uninitialized.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="style"/> is not a <see cref="T:System.Globalization.NumberStyles"/> value.
        /// 
        ///                     -or-
        ///                 <paramref name="style"/> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier"/> value.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result);

        /// <summary>
        /// Converts the value of a specified instance of <see cref="T:System.Decimal"/> to its equivalent binary representation.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer array with four elements that contain the binary representation of <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/> value.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static int[] GetBits(decimal d);

        /// <summary>
        /// Computes the remainder after dividing two <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> that is the remainder after dividing <paramref name="d1"/> by <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/> (the dividend).
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/> (the divisor).
        ///                 </param><exception cref="T:System.DivideByZeroException"><paramref name="d2"/> is zero.
        ///                 </exception><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal Remainder(decimal d1, decimal d2);

        /// <summary>
        /// Multiplies two specified <see cref="T:System.Decimal"/> values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> that is the result of multiplying <paramref name="d1"/> and <paramref name="d2"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/> (the multiplicand).
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/> (the multiplier).
        ///                 </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal Multiply(decimal d1, decimal d2);

        /// <summary>
        /// Returns the result of multiplying the specified <see cref="T:System.Decimal"/> value by negative one.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Decimal"/> with the value of <paramref name="d"/>, but the opposite sign.
        /// 
        ///                     -or-
        /// 
        ///                     Zero, if <paramref name="d"/> is zero.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/>.
        ///                 </param><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static decimal Negate(decimal d);

        /// <summary>
        /// Rounds a decimal value to the nearest integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The integer that is nearest to the <paramref name="d"/> parameter. If <paramref name="d"/> is halfway between two integers, one of which is even and the other odd, the even number is returned.
        /// 
        /// </returns>
        /// <param name="d">A decimal number to round.
        ///                 </param><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal"/> object.
        ///                 </exception><filterpriority>1</filterpriority>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static decimal Round(decimal d);

        /// <summary>
        /// Rounds a <see cref="T:System.Decimal"/> value to a specified number of decimal places.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> number equivalent to <paramref name="d"/> rounded to <paramref name="decimals"/> number of decimal places.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/> value to round.
        ///                 </param><param name="decimals">A value from 0 to 28 that specifies the number of decimal places to round to.
        ///                 </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="decimals"/> is not a value from 0 to 28.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal Round(decimal d, int decimals);

        /// <summary>
        /// Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway between two other numbers.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The integer that is nearest to the <paramref name="d"/> parameter. If <paramref name="d"/> is halfway between two numbers, one of which is even and the other odd, the <paramref name="mode"/> parameter determines which of the two numbers is returned.
        /// 
        /// </returns>
        /// <param name="d">A decimal number to round.
        ///                 </param><param name="mode">A value that specifies how to round <paramref name="d"/> if it is midway between two other numbers.
        ///                 </param><exception cref="T:System.ArgumentException"><paramref name="mode"/> is not a <see cref="T:System.MidpointRounding"/> value.
        ///                 </exception><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal"/> object.
        ///                 </exception><filterpriority>1</filterpriority>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static decimal Round(decimal d, MidpointRounding mode);

        /// <summary>
        /// Rounds a decimal value to a specified precision. A parameter specifies how to round the value if it is midway between two other numbers.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The number that is nearest to the <paramref name="d"/> parameter with a precision equal to the <paramref name="decimals"/> parameter. If <paramref name="d"/> is halfway between two numbers, one of which is even and the other odd, the <paramref name="mode"/> parameter determines which of the two numbers is returned. If the precision of <paramref name="d"/> is less than <paramref name="decimals"/>, <paramref name="d"/> is returned unchanged.
        /// 
        /// </returns>
        /// <param name="d">A decimal number to round.
        ///                 </param><param name="decimals">The number of significant decimal places (precision) in the return value.
        ///                 </param><param name="mode">A value that specifies how to round <paramref name="d"/> if it is midway between two other numbers.
        ///                 </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="decimals"/> is less than 0 or greater than 28.
        ///                 </exception><exception cref="T:System.ArgumentException"><paramref name="mode"/> is not a <see cref="T:System.MidpointRounding"/> value.
        ///                 </exception><exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal"/> object.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        public static decimal Round(decimal d, int decimals, MidpointRounding mode);

        /// <summary>
        /// Subtracts one specified <see cref="T:System.Decimal"/> value from another.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> result of subtracting <paramref name="d2"/> from <paramref name="d1"/>.
        /// 
        /// </returns>
        /// <param name="d1">A <see cref="T:System.Decimal"/> (the minuend).
        ///                 </param><param name="d2">A <see cref="T:System.Decimal"/> (the subtrahend).
        ///                 </param><exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue"/> or greater than <see cref="F:System.Decimal.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal Subtract(decimal d1, decimal d2);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 8-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit unsigned integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">The <see cref="T:System.Decimal"/> value.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static byte ToByte(decimal value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 8-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// An 8-bit signed integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> value.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.SByte.MinValue"/> or greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static sbyte ToSByte(decimal value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 16-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit signed integer equivalent to <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> value.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [__DynamicallyInvokable]
        public static short ToInt16(decimal value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent double-precision floating-point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A double-precision floating-point number equivalent to <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">The <see cref="T:System.Decimal"/> value to convert.
        ///                 </param><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static double ToDouble(decimal d);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 32-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit signed integer equivalent to the value of <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">The <see cref="T:System.Decimal"/> value to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="d"/> is less than <see cref="F:System.Int32.MinValue"/> or greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static int ToInt32(decimal d);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 64-bit signed integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit signed integer equivalent to the value of <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">The <see cref="T:System.Decimal"/> value to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="d"/> is less than <see cref="F:System.Int64.MinValue"/> or greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static long ToInt64(decimal d);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 16-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 16-bit unsigned integer equivalent to the value of <paramref name="value"/>.
        /// 
        /// </returns>
        /// <param name="value">A <see cref="T:System.Decimal"/> value to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="value"/> is greater than <see cref="F:System.UInt16.MaxValue"/> or less than <see cref="F:System.UInt16.MinValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static ushort ToUInt16(decimal value);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 32-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 32-bit unsigned integer equivalent to the value of <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/> value to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="d"/> is negative or greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [CLSCompliant(false)]
        [__DynamicallyInvokable]
        public static uint ToUInt32(decimal d);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent 64-bit unsigned integer.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A 64-bit unsigned integer equivalent to the value of <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/> value to convert.
        ///                 </param><exception cref="T:System.OverflowException"><paramref name="d"/> is negative or greater than <see cref="F:System.UInt64.MaxValue"/>.
        ///                 </exception><filterpriority>1</filterpriority>
        [CLSCompliant(false)]
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static ulong ToUInt64(decimal d);

        /// <summary>
        /// Converts the value of the specified <see cref="T:System.Decimal"/> to the equivalent single-precision floating-point number.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A single-precision floating-point number equivalent to the value of <paramref name="d"/>.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/> value to convert.
        ///                 </param><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static float ToSingle(decimal d);

        /// <summary>
        /// Returns the integral digits of the specified <see cref="T:System.Decimal"/>; any fractional digits are discarded.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Decimal"/> result of <paramref name="d"/> rounded toward zero, to the nearest whole number.
        /// 
        /// </returns>
        /// <param name="d">A <see cref="T:System.Decimal"/> to truncate.
        ///                 </param><filterpriority>1</filterpriority>
        [SecuritySafeCritical]
        [__DynamicallyInvokable]
        public static decimal Truncate(decimal d);

        /// <summary>
        /// Returns the <see cref="T:System.TypeCode"/> for value type <see cref="T:System.Decimal"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The enumerated constant <see cref="F:System.TypeCode.Decimal"/>.
        /// 
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public TypeCode GetTypeCode();

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// true if the value of the current instance is not zero; otherwise, false.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param>
        bool IConvertible.ToBoolean(IFormatProvider provider);

        /// <summary>
        /// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.InvalidCastException">In all cases.
        ///                 </exception>
        char IConvertible.ToChar(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.SByte"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.SByte.MinValue"/> or greater than <see cref="F:System.SByte.MaxValue"/>.
        ///                 </exception>
        sbyte IConvertible.ToSByte(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.Byte"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Byte.MinValue"/> or greater than <see cref="F:System.Byte.MaxValue"/>.
        ///                 </exception>
        byte IConvertible.ToByte(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.Int16"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int16.MinValue"/> or greater than <see cref="F:System.Int16.MaxValue"/>.
        ///                 </exception>
        short IConvertible.ToInt16(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.UInt16"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt16.MinValue"/> or greater than <see cref="F:System.UInt16.MaxValue"/>.
        ///                 </exception>
        ushort IConvertible.ToUInt16(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.Int32"/>.
        /// 
        /// </returns>
        /// <param name="provider">The parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int32.MinValue"/> or greater than <see cref="F:System.Int32.MaxValue"/>.
        ///                 </exception>
        int IConvertible.ToInt32(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.UInt32"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt32.MinValue"/> or greater than <see cref="F:System.UInt32.MaxValue"/>.
        ///                 </exception>
        uint IConvertible.ToUInt32(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.Int64"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int64.MinValue"/> or greater than <see cref="F:System.Int64.MaxValue"/>.
        ///                 </exception>
        long IConvertible.ToInt64(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.UInt64"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt64.MinValue"/> or greater than <see cref="F:System.UInt64.MaxValue"/>.
        ///                 </exception>
        ulong IConvertible.ToUInt64(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.Single"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param>
        float IConvertible.ToSingle(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <see cref="T:System.Double"/>.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param>
        double IConvertible.ToDouble(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, unchanged.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param>
        decimal IConvertible.ToDecimal(IFormatProvider provider);

        /// <summary>
        /// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// This conversion is not supported. No value is returned.
        /// 
        /// </returns>
        /// <param name="provider">This parameter is ignored.
        ///                 </param><exception cref="T:System.InvalidCastException">In all cases.
        ///                 </exception>
        DateTime IConvertible.ToDateTime(IFormatProvider provider);

        /// <summary>
        /// For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)"/>.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current instance, converted to a <paramref name="type"/>.
        /// 
        /// </returns>
        /// <param name="type">The type to which to convert the value of this <see cref="T:System.Decimal"/> instance.
        ///                 </param><param name="provider">An <see cref="T:System.IFormatProvider"/> implementation that supplies culture-specific information about the format of the returned value.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> is null.
        ///                 </exception><exception cref="T:System.InvalidCastException">The requested type conversion is not supported.
        ///                 </exception>
        object IConvertible.ToType(Type type, IFormatProvider provider);
    }
}
