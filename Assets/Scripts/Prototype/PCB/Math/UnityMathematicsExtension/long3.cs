using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Unity.Mathematics.Extensions
{
    /// <summary>A 3 component vector of longs.</summary>
    [DebuggerTypeProxy(typeof(long3.DebuggerProxy))]
    [System.Serializable]
    public partial struct long3 : System.IEquatable<long3>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public long x;
        /// <summary>y component of the vector.</summary>
        public long y;
        /// <summary>z component of the vector.</summary>
        public long z;

        /// <summary>long3 zero value.</summary>
        public static readonly long3 zero;

        /// <summary>Constructs a long3 vector from three long values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long x, long y, long z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a long3 vector from an long value and an long2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long x, long2 yz)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a long3 vector from an long2 vector and an long value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long2 xy, long z)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a long3 vector from an long3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long3 xyz)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a long3 vector from a single long value by assigning it to every component.</summary>
        /// <param name="v">long to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(long v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a long3 vector from a single bool value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">bool to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(bool v)
        {
            this.x = v ? 1 : 0;
            this.y = v ? 1 : 0;
            this.z = v ? 1 : 0;
        }

        /// <summary>Constructs a long3 vector from a bool3 vector by componentwise conversion.</summary>
        /// <param name="v">bool3 to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(bool3 v)
        {
            this.x = v.x ? 1 : 0;
            this.y = v.y ? 1 : 0;
            this.z = v.z ? 1 : 0;
        }

        /// <summary>Constructs a long3 vector from a single ulong value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">ulong to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(ulong v)
        {
            this.x = (long)v;
            this.y = (long)v;
            this.z = (long)v;
        }

        /// <summary>Constructs a long3 vector from a ulong3 vector by componentwise conversion.</summary>
        /// <param name="v">ulong3 to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(ulong3 v)
        {
            this.x = (long)v.x;
            this.y = (long)v.y;
            this.z = (long)v.z;
        }

        /// <summary>Constructs a long3 vector from a single float value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">float to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(float v)
        {
            this.x = (long)v;
            this.y = (long)v;
            this.z = (long)v;
        }

        /// <summary>Constructs a long3 vector from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(float3 v)
        {
            this.x = (long)v.x;
            this.y = (long)v.y;
            this.z = (long)v.z;
        }

        /// <summary>Constructs a long3 vector from a single double value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">double to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(double v)
        {
            this.x = (long)v;
            this.y = (long)v;
            this.z = (long)v;
        }

        /// <summary>Constructs a long3 vector from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to long3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long3(double3 v)
        {
            this.x = (long)v.x;
            this.y = (long)v.y;
            this.z = (long)v.z;
        }


        /// <summary>Implicitly converts a single long value to a long3 vector by assigning it to every component.</summary>
        /// <param name="v">long to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(long v) { return new long3(v); }

        /// <summary>Explicitly converts a single bool value to a long3 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">bool to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(bool v) { return new long3(v); }

        /// <summary>Explicitly converts a bool3 vector to a long3 vector by componentwise conversion.</summary>
        /// <param name="v">bool3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(bool3 v) { return new long3(v); }

        /// <summary>Explicitly converts a single ulong value to a long3 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">ulong to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(ulong v) { return new long3(v); }

        /// <summary>Explicitly converts a ulong3 vector to a long3 vector by componentwise conversion.</summary>
        /// <param name="v">ulong3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(ulong3 v) { return new long3(v); }

        /// <summary>Explicitly converts a single float value to a long3 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">float to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(float v) { return new long3(v); }

        /// <summary>Explicitly converts a float3 vector to a long3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(float3 v) { return new long3(v); }

        /// <summary>Explicitly converts a single double value to a long3 vector by converting it to long and assigning it to every component.</summary>
        /// <param name="v">double to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(double v) { return new long3(v); }

        /// <summary>Explicitly converts a double3 vector to a long3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long3(double3 v) { return new long3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise multiplication.</param>
        /// <returns>long3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator * (long3 lhs, long3 rhs) { return new long3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise multiplication.</param>
        /// <returns>long3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator * (long3 lhs, long rhs) { return new long3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise multiplication.</param>
        /// <returns>long3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator * (long lhs, long3 rhs) { return new long3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }


        /// <summary>Returns the result of a componentwise addition operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise addition.</param>
        /// <returns>long3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator + (long3 lhs, long3 rhs) { return new long3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise addition.</param>
        /// <returns>long3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator + (long3 lhs, long rhs) { return new long3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise addition.</param>
        /// <returns>long3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator + (long lhs, long3 rhs) { return new long3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise subtraction.</param>
        /// <returns>long3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator - (long3 lhs, long3 rhs) { return new long3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise subtraction.</param>
        /// <returns>long3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator - (long3 lhs, long rhs) { return new long3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise subtraction.</param>
        /// <returns>long3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator - (long lhs, long3 rhs) { return new long3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise division.</param>
        /// <returns>long3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator / (long3 lhs, long3 rhs) { return new long3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise division.</param>
        /// <returns>long3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator / (long3 lhs, long rhs) { return new long3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise division.</param>
        /// <returns>long3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator / (long lhs, long3 rhs) { return new long3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise modulus.</param>
        /// <returns>long3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator % (long3 lhs, long3 rhs) { return new long3 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise modulus.</param>
        /// <returns>long3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator % (long3 lhs, long rhs) { return new long3 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise modulus.</param>
        /// <returns>long3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator % (long lhs, long3 rhs) { return new long3 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on an long3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>long3 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator ++ (long3 val) { return new long3 (++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on an long3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>long3 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator -- (long3 val) { return new long3 (--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (long3 lhs, long3 rhs) { return new bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (long3 lhs, long rhs) { return new bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (long lhs, long3 rhs) { return new bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (long3 lhs, long3 rhs) { return new bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (long3 lhs, long rhs) { return new bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (long lhs, long3 rhs) { return new bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (long3 lhs, long3 rhs) { return new bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (long3 lhs, long rhs) { return new bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (long lhs, long3 rhs) { return new bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (long3 lhs, long3 rhs) { return new bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (long3 lhs, long rhs) { return new bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (long lhs, long3 rhs) { return new bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on an long3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>long3 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator - (long3 val) { return new long3 (-val.x, -val.y, -val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on an long3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>long3 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator + (long3 val) { return new long3 (+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise left shift operation on an long3 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator << (long3 x, int n) { return new long3 (x.x << n, x.y << n, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an long3 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator >> (long3 x, int n) { return new long3 (x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (long3 lhs, long3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (long3 lhs, long rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (long lhs, long3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (long3 lhs, long3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (long3 lhs, long rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (long lhs, long3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an long3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise bitwise not.</param>
        /// <returns>long3 result of the componentwise bitwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator ~ (long3 val) { return new long3 (~val.x, ~val.y, ~val.z); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise bitwise and.</param>
        /// <returns>long3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator & (long3 lhs, long3 rhs) { return new long3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise bitwise and.</param>
        /// <returns>long3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator & (long3 lhs, long rhs) { return new long3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise bitwise and.</param>
        /// <returns>long3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator & (long lhs, long3 rhs) { return new long3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise bitwise or.</param>
        /// <returns>long3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator | (long3 lhs, long3 rhs) { return new long3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise bitwise or.</param>
        /// <returns>long3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator | (long3 lhs, long rhs) { return new long3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise bitwise or.</param>
        /// <returns>long3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator | (long lhs, long3 rhs) { return new long3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two long3 vectors.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>long3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator ^ (long3 lhs, long3 rhs) { return new long3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an long3 vector and an long value.</summary>
        /// <param name="lhs">Left hand side long3 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side long to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>long3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator ^ (long3 lhs, long rhs) { return new long3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an long value and an long3 vector.</summary>
        /// <param name="lhs">Left hand side long to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side long3 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>long3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 operator ^ (long lhs, long3 rhs) { return new long3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }




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



        /// <summary>Returns the long element at a specified index.</summary>
        unsafe public long this[long index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (long3* array = &this) { return ((long*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (long* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the long3 is equal to a given long3, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(long3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the long3 is equal to a given long3, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is long3 converted && Equals(converted); }


        /// <summary>Returns a hash code for the long3.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (long)math.hash(this); }


        /// <summary>Returns a string representation of the long3.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("long3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the long3 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("long3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public long x;
            public long y;
            public long z;
            public DebuggerProxy(long3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a long3 vector constructed from three long values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>long3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long x, long y, long z) { return new long3(x, y, z); }

        /// <summary>Returns a long3 vector constructed from an long value and an long2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <returns>long3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long x, long2 yz) { return new long3(x, yz); }

        /// <summary>Returns a long3 vector constructed from an long2 vector and an long value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>long3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long2 xy, long z) { return new long3(xy, z); }

        /// <summary>Returns a long3 vector constructed from an long3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <returns>long3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long3 xyz) { return new long3(xyz); }

        /// <summary>Returns a long3 vector constructed from a single long value by assigning it to every component.</summary>
        /// <param name="v">long to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(long v) { return new long3(v); }

        /// <summary>Returns a long3 vector constructed from a single bool value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">bool to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(bool v) { return new long3(v); }

        /// <summary>Return a long3 vector constructed from a bool3 vector by componentwise conversion.</summary>
        /// <param name="v">bool3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(bool3 v) { return new long3(v); }

        /// <summary>Returns a long3 vector constructed from a single ulong value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">ulong to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(ulong v) { return new long3(v); }

        /// <summary>Return a long3 vector constructed from a ulong3 vector by componentwise conversion.</summary>
        /// <param name="v">ulong3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(ulong3 v) { return new long3(v); }

        /// <summary>Returns a long3 vector constructed from a single float value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">float to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(float v) { return new long3(v); }

        /// <summary>Return a long3 vector constructed from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(float3 v) { return new long3(v); }

        /// <summary>Returns a long3 vector constructed from a single double value by converting it to long and assigning it to every component.</summary>
        /// <param name="v">double to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(double v) { return new long3(v); }

        /// <summary>Return a long3 vector constructed from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to long3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 long3(double3 v) { return new long3(v); }

        /// <summary>Returns a ulong hash code of a long3 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong hash(long3 v)
        {
            return csum(asulong(v) * ulong3(0x4C7F6DD1u, 0x4822A3E9u, 0xAAC3C25Du)) + 0xD21D0945u;
        }

        /// <summary>
        /// Returns a ulong3 vector hash code of a long3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow ulong hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong3 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 hashwide(long3 v)
        {
            return (asulong(v) * ulong3(0x88FCAB2Du, 0x614DA60Du, 0x5BA2C50Bu)) + 0x8C455ACBu;
        }
    }
}