using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Unity.Mathematics.Extensions
{
    /// <summary>A 4 component vector of longs.</summary>
    [DebuggerTypeProxy(typeof(long4.DebuggerProxy))]
    [System.Serializable]
    public partial struct long4 : System.IEquatable<long4>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public long x;
        /// <summary>y component of the vector.</summary>
        public long y;
        /// <summary>z component of the vector.</summary>
        public long z;
        /// <summary>w component of the vector.</summary>
        public long w;

        /// <summary>long4 zero value.</summary>
        public static readonly long4 zero;

        /// <summary>Constructs a long4 vector from four long values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long y, long z, long w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a long4 vector from two long values and an long2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long y, long2 zw)
        {
            this.x = x;
            this.y = y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a long4 vector from an long value, an long2 vector and an long value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long2 yz, long w)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a long4 vector from an long value and an long3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long x, long3 yzw)
        {
            this.x = x;
            this.y = yzw.x;
            this.z = yzw.y;
            this.w = yzw.z;
        }

        /// <summary>Constructs a long4 vector from an long2 vector and two long values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long2 xy, long z, long w)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a long4 vector from two long2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long2 xy, long2 zw)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a long4 vector from an long3 vector and an long value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long3 xyz, long w)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a long4 vector from an long4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long4 xyzw)
        {
            this.x = xyzw.x;
            this.y = xyzw.y;
            this.z = xyzw.z;
            this.w = xyzw.w;
        }

        /// <summary>Constructs a long4 vector from a single long value by assigning it to every component.</summary>
        /// <param name="v">long to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(long v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a long4 vector from a single bool value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">bool to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(bool v)
        {
            this.x = v ? 1 : 0;
            this.y = v ? 1 : 0;
            this.z = v ? 1 : 0;
            this.w = v ? 1 : 0;
        }

        /// <summary>Constructs a long4 vector from a bool4 vector by componentwise conversion.</summary>
        /// <param name="v">bool4 to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(bool4 v)
        {
            this.x = v.x ? 1 : 0;
            this.y = v.y ? 1 : 0;
            this.z = v.z ? 1 : 0;
            this.w = v.w ? 1 : 0;
        }

        /// <summary>Constructs a long4 vector from a single ulong value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">ulong to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(ulong v)
        {
            this.x = (long)v;
            this.y = (long)v;
            this.z = (long)v;
            this.w = (long)v;
        }

        /// <summary>Constructs a long4 vector from a ulong4 vector by componentwise conversion.</summary>
        /// <param name="v">ulong4 to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(ulong4 v)
        {
            this.x = (long)v.x;
            this.y = (long)v.y;
            this.z = (long)v.z;
            this.w = (long)v.w;
        }

        /// <summary>Constructs a long4 vector from a single float value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">float to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(float v)
        {
            this.x = (long)v;
            this.y = (long)v;
            this.z = (long)v;
            this.w = (long)v;
        }

        /// <summary>Constructs a long4 vector from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(float4 v)
        {
            this.x = (long)v.x;
            this.y = (long)v.y;
            this.z = (long)v.z;
            this.w = (long)v.w;
        }

        /// <summary>Constructs a long4 vector from a single double value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">double to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(double v)
        {
            this.x = (long)v;
            this.y = (long)v;
            this.z = (long)v;
            this.w = (long)v;
        }

        /// <summary>Constructs a long4 vector from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to long4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4(double4 v)
        {
            this.x = (long)v.x;
            this.y = (long)v.y;
            this.z = (long)v.z;
            this.w = (long)v.w;
        }


        /// <summary>Implicitly converts a single long value to a long4 vector by assigning it to every component.</summary>
        /// <param name="v">long to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(long v) { return new long4(v); }

        /// <summary>Explicitly converts a single bool value to a long4 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">bool to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(bool v) { return new long4(v); }

        /// <summary>Explicitly converts a bool4 vector to a long4 vector by componentwise conversion.</summary>
        /// <param name="v">bool4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(bool4 v) { return new long4(v); }

        /// <summary>Explicitly converts a single ulong value to a long4 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">ulong to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(ulong v) { return new long4(v); }

        /// <summary>Explicitly converts a ulong4 vector to a long4 vector by componentwise conversion.</summary>
        /// <param name="v">ulong4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(ulong4 v) { return new long4(v); }

        /// <summary>Explicitly converts a single float value to a long4 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">float to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(float v) { return new long4(v); }

        /// <summary>Explicitly converts a float4 vector to a long4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(float4 v) { return new long4(v); }

        /// <summary>Explicitly converts a single double value to a long4 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">double to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(double v) { return new long4(v); }

        /// <summary>Explicitly converts a double4 vector to a long4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long4(double4 v) { return new long4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise multiplication.</param>
        /// <returns>long4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator * (long4 lhs, long4 rhs) { return new long4 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise multiplication.</param>
        /// <returns>long4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator * (long4 lhs, long rhs) { return new long4 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise multiplication.</param>
        /// <returns>long4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator * (long lhs, long4 rhs) { return new long4 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise addition.</param>
        /// <returns>long4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator + (long4 lhs, long4 rhs) { return new long4 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise addition.</param>
        /// <returns>long4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator + (long4 lhs, long rhs) { return new long4 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise addition.</param>
        /// <returns>long4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator + (long lhs, long4 rhs) { return new long4 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise subtraction.</param>
        /// <returns>long4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator - (long4 lhs, long4 rhs) { return new long4 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise subtraction.</param>
        /// <returns>long4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator - (long4 lhs, long rhs) { return new long4 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise subtraction.</param>
        /// <returns>long4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator - (long lhs, long4 rhs) { return new long4 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise division.</param>
        /// <returns>long4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator / (long4 lhs, long4 rhs) { return new long4 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise division.</param>
        /// <returns>long4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator / (long4 lhs, long rhs) { return new long4 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise division.</param>
        /// <returns>long4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator / (long lhs, long4 rhs) { return new long4 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise modulus.</param>
        /// <returns>long4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator % (long4 lhs, long4 rhs) { return new long4 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise modulus.</param>
        /// <returns>long4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator % (long4 lhs, long rhs) { return new long4 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise modulus.</param>
        /// <returns>long4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator % (long lhs, long4 rhs) { return new long4 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise increment operation on an long4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>long4 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator ++ (long4 val) { return new long4 (++val.x, ++val.y, ++val.z, ++val.w); }


        /// <summary>Returns the result of a componentwise decrement operation on an long4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>long4 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator -- (long4 val) { return new long4 (--val.x, --val.y, --val.z, --val.w); }


        /// <summary>Returns the result of a componentwise less than operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator < (long4 lhs, long4 rhs) { return new bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator < (long4 lhs, long rhs) { return new bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator < (long lhs, long4 rhs) { return new bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <= (long4 lhs, long4 rhs) { return new bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <= (long4 lhs, long rhs) { return new bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <= (long lhs, long4 rhs) { return new bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator > (long4 lhs, long4 rhs) { return new bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator > (long4 lhs, long rhs) { return new bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator > (long lhs, long4 rhs) { return new bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >= (long4 lhs, long4 rhs) { return new bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >= (long4 lhs, long rhs) { return new bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >= (long lhs, long4 rhs) { return new bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on an long4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>long4 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator - (long4 val) { return new long4 (-val.x, -val.y, -val.z, -val.w); }


        /// <summary>Returns the result of a componentwise unary plus operation on an long4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>long4 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator + (long4 val) { return new long4 (+val.x, +val.y, +val.z, +val.w); }


        /// <summary>Returns the result of a componentwise left shift operation on an long4 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator << (long4 x, int n) { return new long4 (x.x << n, x.y << n, x.z << n, x.w << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an long4 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator >> (long4 x, int n) { return new long4 (x.x >> n, x.y >> n, x.z >> n, x.w >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (long4 lhs, long4 rhs) { return new bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (long4 lhs, long rhs) { return new bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (long lhs, long4 rhs) { return new bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (long4 lhs, long4 rhs) { return new bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (long4 lhs, long rhs) { return new bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (long lhs, long4 rhs) { return new bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an long4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise bitwise not.</param>
        /// <returns>long4 result of the componentwise bitwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator ~ (long4 val) { return new long4 (~val.x, ~val.y, ~val.z, ~val.w); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise bitwise and.</param>
        /// <returns>long4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator & (long4 lhs, long4 rhs) { return new long4 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise bitwise and.</param>
        /// <returns>long4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator & (long4 lhs, long rhs) { return new long4 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise bitwise and.</param>
        /// <returns>long4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator & (long lhs, long4 rhs) { return new long4 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise bitwise or.</param>
        /// <returns>long4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator | (long4 lhs, long4 rhs) { return new long4 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise bitwise or.</param>
        /// <returns>long4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator | (long4 lhs, long rhs) { return new long4 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise bitwise or.</param>
        /// <returns>long4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator | (long lhs, long4 rhs) { return new long4 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two long4 vectors.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>long4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator ^ (long4 lhs, long4 rhs) { return new long4 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an long4 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long4 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>long4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator ^ (long4 lhs, long rhs) { return new long4 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an long value and an long4 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side long4 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>long4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 operator ^ (long lhs, long4 rhs) { return new long4 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w); }




        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 xwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(x, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 yzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 ywww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(y, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 zwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(z, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long4 wwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long4(w, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 xww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 ywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 ywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 ywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 yww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 zww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 wwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long3 www
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long3(w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 xw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 yw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 zw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 wx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 wy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 wz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public long2 ww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new long2(w, w); }
        }



        /// <summary>Returns the long element at a specified index.</summary>
        unsafe public long this[long index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (long4* array = &this) { return ((long*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (long* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the long4 is equal to a given long4, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(long4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the long4 is equal to a given long4, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is long4 converted && Equals(converted); }


        /// <summary>Returns a hash code for the long4.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (long)math.hash(this); }


        /// <summary>Returns a string representation of the long4.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("long4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        /// <summary>Returns a string representation of the long4 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("long4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public long x;
            public long y;
            public long z;
            public long w;
            public DebuggerProxy(long4 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a long4 vector constructed from four long values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long x, long y, long z, long w) { return new long4(x, y, z, w); }

        /// <summary>Returns a long4 vector constructed from two long values and an long2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long x, long y, long2 zw) { return new long4(x, y, zw); }

        /// <summary>Returns a long4 vector constructed from an long value, an long2 vector and an long value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long x, long2 yz, long w) { return new long4(x, yz, w); }

        /// <summary>Returns a long4 vector constructed from an long value and an long3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long x, long3 yzw) { return new long4(x, yzw); }

        /// <summary>Returns a long4 vector constructed from an long2 vector and two long values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long2 xy, long z, long w) { return new long4(xy, z, w); }

        /// <summary>Returns a long4 vector constructed from two long2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long2 xy, long2 zw) { return new long4(xy, zw); }

        /// <summary>Returns a long4 vector constructed from an long3 vector and an long value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long3 xyz, long w) { return new long4(xyz, w); }

        /// <summary>Returns a long4 vector constructed from an long4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        /// <returns>long4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long4 xyzw) { return new long4(xyzw); }

        /// <summary>Returns a long4 vector constructed from a single long value by assigning it to every component.</summary>
        /// <param name="v">long to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(long v) { return new long4(v); }

        /// <summary>Returns a long4 vector constructed from a single bool value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">bool to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(bool v) { return new long4(v); }

        /// <summary>Return a long4 vector constructed from a bool4 vector by componentwise conversion.</summary>
        /// <param name="v">bool4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(bool4 v) { return new long4(v); }

        /// <summary>Returns a long4 vector constructed from a single ulong value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">ulong to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(ulong v) { return new long4(v); }

        /// <summary>Return a long4 vector constructed from a ulong4 vector by componentwise conversion.</summary>
        /// <param name="v">ulong4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(ulong4 v) { return new long4(v); }

        /// <summary>Returns a long4 vector constructed from a single float value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">float to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(float v) { return new long4(v); }

        /// <summary>Return a long4 vector constructed from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(float4 v) { return new long4(v); }

        /// <summary>Returns a long4 vector constructed from a single double value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">double to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(double v) { return new long4(v); }

        /// <summary>Return a long4 vector constructed from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to long4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 long4(double4 v) { return new long4(v); }

        /// <summary>Returns a ulong hash code of a long4 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong hash(long4 v)
        {
            return csum(asulong(v) * ulong4(0x6E050B01u, 0x750FDBF5u, 0x7F3DD499u, 0x52EAAEBBu)) + 0x4599C793u;
        }

        /// <summary>
        /// Returns a ulong4 vector hash code of a long4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow ulong hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong4 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 hashwide(long4 v)
        {
            return (asulong(v) * ulong4(0x83B5E729u, 0xC267163Fu, 0x67BC9149u, 0xAD7C5EC1u)) + 0x822A7D6Du;
        }
    }
}