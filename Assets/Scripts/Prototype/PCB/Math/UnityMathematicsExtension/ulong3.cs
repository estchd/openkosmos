using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Unity.Mathematics.Extensions
{
    /// <summary>A 3 component vector of ulongs.</summary>
    [DebuggerTypeProxy(typeof(ulong3.DebuggerProxy))]
    [System.Serializable]
    public partial struct ulong3 : System.IEquatable<ulong3>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public ulong x;
        /// <summary>y component of the vector.</summary>
        public ulong y;
        /// <summary>z component of the vector.</summary>
        public ulong z;

        /// <summary>ulong3 zero value.</summary>
        public static readonly ulong3 zero;

        /// <summary>Constructs a ulong3 vector from three ulong values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong x, ulong y, ulong z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a ulong3 vector from a ulong value and a ulong2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong x, ulong2 yz)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a ulong3 vector from a ulong2 vector and a ulong value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong2 xy, ulong z)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a ulong3 vector from a ulong3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong3 xyz)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a ulong3 vector from a single ulong value by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a ulong3 vector from a single bool value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(bool v)
        {
            this.x = v ? 1u : 0u;
            this.y = v ? 1u : 0u;
            this.z = v ? 1u : 0u;
        }

        /// <summary>Constructs a ulong3 vector from a bool3 vector by componentwise conversion.</summary>
        /// <param name="v">bool3 to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(bool3 v)
        {
            this.x = v.x ? 1u : 0u;
            this.y = v.y ? 1u : 0u;
            this.z = v.z ? 1u : 0u;
        }

        /// <summary>Constructs a ulong3 vector from a single long value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(long v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
            this.z = (ulong)v;
        }

        /// <summary>Constructs a ulong3 vector from a long3 vector by componentwise conversion.</summary>
        /// <param name="v">long3 to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(long3 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
            this.z = (ulong)v.z;
        }

        /// <summary>Constructs a ulong3 vector from a single float value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(float v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
            this.z = (ulong)v;
        }

        /// <summary>Constructs a ulong3 vector from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(float3 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
            this.z = (ulong)v.z;
        }

        /// <summary>Constructs a ulong3 vector from a single double value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(double v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
            this.z = (ulong)v;
        }

        /// <summary>Constructs a ulong3 vector from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to ulong3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(double3 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
            this.z = (ulong)v.z;
        }


        /// <summary>Implicitly converts a single ulong value to a ulong3 vector by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(ulong v) { return new ulong3(v); }

        /// <summary>Explicitly converts a single bool value to a ulong3 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(bool v) { return new ulong3(v); }

        /// <summary>Explicitly converts a bool3 vector to a ulong3 vector by componentwise conversion.</summary>
        /// <param name="v">bool3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(bool3 v) { return new ulong3(v); }

        /// <summary>Explicitly converts a single long value to a ulong3 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(long v) { return new ulong3(v); }

        /// <summary>Explicitly converts a long3 vector to a ulong3 vector by componentwise conversion.</summary>
        /// <param name="v">long3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(long3 v) { return new ulong3(v); }

        /// <summary>Explicitly converts a single float value to a ulong3 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(float v) { return new ulong3(v); }

        /// <summary>Explicitly converts a float3 vector to a ulong3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(float3 v) { return new ulong3(v); }

        /// <summary>Explicitly converts a single double value to a ulong3 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(double v) { return new ulong3(v); }

        /// <summary>Explicitly converts a double3 vector to a ulong3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(double3 v) { return new ulong3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise multiplication.</param>
        /// <returns>ulong3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator * (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise multiplication.</param>
        /// <returns>ulong3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator * (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise multiplication.</param>
        /// <returns>ulong3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator * (ulong lhs, ulong3 rhs) { return new ulong3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }


        /// <summary>Returns the result of a componentwise addition operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise addition.</param>
        /// <returns>ulong3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator + (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise addition.</param>
        /// <returns>ulong3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator + (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise addition.</param>
        /// <returns>ulong3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator + (ulong lhs, ulong3 rhs) { return new ulong3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise subtraction.</param>
        /// <returns>ulong3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator - (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise subtraction.</param>
        /// <returns>ulong3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator - (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise subtraction.</param>
        /// <returns>ulong3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator - (ulong lhs, ulong3 rhs) { return new ulong3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise division.</param>
        /// <returns>ulong3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator / (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise division.</param>
        /// <returns>ulong3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator / (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise division.</param>
        /// <returns>ulong3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator / (ulong lhs, ulong3 rhs) { return new ulong3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise modulus.</param>
        /// <returns>ulong3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator % (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise modulus.</param>
        /// <returns>ulong3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator % (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise modulus.</param>
        /// <returns>ulong3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator % (ulong lhs, ulong3 rhs) { return new ulong3 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on a ulong3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>ulong3 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ++ (ulong3 val) { return new ulong3 (++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on a ulong3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>ulong3 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator -- (ulong3 val) { return new ulong3 (--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (ulong3 lhs, ulong3 rhs) { return new bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (ulong3 lhs, ulong rhs) { return new bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (ulong lhs, ulong3 rhs) { return new bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (ulong3 lhs, ulong3 rhs) { return new bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (ulong3 lhs, ulong rhs) { return new bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (ulong lhs, ulong3 rhs) { return new bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (ulong3 lhs, ulong3 rhs) { return new bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (ulong3 lhs, ulong rhs) { return new bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (ulong lhs, ulong3 rhs) { return new bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (ulong3 lhs, ulong3 rhs) { return new bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (ulong3 lhs, ulong rhs) { return new bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (ulong lhs, ulong3 rhs) { return new bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on a ulong3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>ulong3 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator - (ulong3 val) { return new ulong3 ((ulong)-val.x, (ulong)-val.y, (ulong)-val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on a ulong3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>ulong3 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator + (ulong3 val) { return new ulong3 (+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise left shift operation on a ulong3 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator << (ulong3 x, int n) { return new ulong3 (x.x << n, x.y << n, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a ulong3 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator >> (ulong3 x, int n) { return new ulong3 (x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (ulong3 lhs, ulong3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (ulong3 lhs, ulong rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (ulong lhs, ulong3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (ulong3 lhs, ulong3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (ulong3 lhs, ulong rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (ulong lhs, ulong3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a ulong3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise bitwise not.</param>
        /// <returns>ulong3 result of the componentwise bitwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ~ (ulong3 val) { return new ulong3 (~val.x, ~val.y, ~val.z); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise bitwise and.</param>
        /// <returns>ulong3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator & (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise and.</param>
        /// <returns>ulong3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator & (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise bitwise and.</param>
        /// <returns>ulong3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator & (ulong lhs, ulong3 rhs) { return new ulong3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise bitwise or.</param>
        /// <returns>ulong3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator | (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise or.</param>
        /// <returns>ulong3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator | (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise bitwise or.</param>
        /// <returns>ulong3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator | (ulong lhs, ulong3 rhs) { return new ulong3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two ulong3 vectors.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ^ (ulong3 lhs, ulong3 rhs) { return new ulong3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a ulong3 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong3 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ^ (ulong3 lhs, ulong rhs) { return new ulong3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a ulong value and a ulong3 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong3 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ^ (ulong lhs, ulong3 rhs) { return new ulong3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }




        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(z, z); }
        }



        /// <summary>Returns the ulong element at a specified index.</summary>
        unsafe public ulong this[long index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (ulong3* array = &this) { return ((ulong*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (ulong* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the ulong3 is equal to a given ulong3, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ulong3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the ulong3 is equal to a given ulong3, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is ulong3 converted && Equals(converted); }


        /// <summary>Returns a hash code for the ulong3.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the ulong3.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("ulong3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the ulong3 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("ulong3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public ulong x;
            public ulong y;
            public ulong z;
            public DebuggerProxy(ulong3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a ulong3 vector constructed from three ulong values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>ulong3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(ulong x, ulong y, ulong z) { return new ulong3(x, y, z); }

        /// <summary>Returns a ulong3 vector constructed from a ulong value and a ulong2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <returns>ulong3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(ulong x, ulong2 yz) { return new ulong3(x, yz); }

        /// <summary>Returns a ulong3 vector constructed from a ulong2 vector and a ulong value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>ulong3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(ulong2 xy, ulong z) { return new ulong3(xy, z); }

        /// <summary>Returns a ulong3 vector constructed from a ulong3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <returns>ulong3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(ulong3 xyz) { return new ulong3(xyz); }

        /// <summary>Returns a ulong3 vector constructed from a single ulong value by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(ulong v) { return new ulong3(v); }

        /// <summary>Returns a ulong3 vector constructed from a single bool value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(bool v) { return new ulong3(v); }

        /// <summary>Return a ulong3 vector constructed from a bool3 vector by componentwise conversion.</summary>
        /// <param name="v">bool3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(bool3 v) { return new ulong3(v); }

        /// <summary>Returns a ulong3 vector constructed from a single long value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(long v) { return new ulong3(v); }

        /// <summary>Return a ulong3 vector constructed from a long3 vector by componentwise conversion.</summary>
        /// <param name="v">long3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(long3 v) { return new ulong3(v); }

        /// <summary>Returns a ulong3 vector constructed from a single float value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(float v) { return new ulong3(v); }

        /// <summary>Return a ulong3 vector constructed from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(float3 v) { return new ulong3(v); }

        /// <summary>Returns a ulong3 vector constructed from a single double value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(double v) { return new ulong3(v); }

        /// <summary>Return a ulong3 vector constructed from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to ulong3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ulong3(double3 v) { return new ulong3(v); }

        /// <summary>Returns a ulong hash code of a ulong3 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong hash(ulong3 v)
        {
            return csum(v * ulong3(0xCD266C89u, 0xF1852A33u, 0x77E35E77u)) + 0x863E3729u;
        }

        /// <summary>
        /// Returns a ulong3 vector hash code of a ulong3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow ulong hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong3 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 hashwide(ulong3 v)
        {
            return (v * ulong3(0xE191B035u, 0x68586FAFu, 0xD4DFF6D3u)) + 0xCB634F4Du;
        }
    }
}