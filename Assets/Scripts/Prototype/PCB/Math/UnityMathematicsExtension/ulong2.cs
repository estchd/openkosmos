﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics.Extensions
{
    /// <summary>A 2 component vector of ulongs.</summary>
    [DebuggerTypeProxy(typeof(ulong2.DebuggerProxy))]
    [System.Serializable]
    public partial struct ulong2 : System.IEquatable<ulong2>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public ulong x;
        /// <summary>y component of the vector.</summary>
        public ulong y;

        /// <summary>ulong2 zero value.</summary>
        public static readonly ulong2 zero;

        /// <summary>Constructs a ulong2 vector from two ulong values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong x, ulong y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a ulong2 vector from a ulong2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong2 xy)
        {
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a ulong2 vector from a single ulong value by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a ulong2 vector from a single bool value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(bool v)
        {
            this.x = v ? 1u : 0u;
            this.y = v ? 1u : 0u;
        }

        /// <summary>Constructs a ulong2 vector from a bool2 vector by componentwise conversion.</summary>
        /// <param name="v">bool2 to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(bool2 v)
        {
            this.x = v.x ? 1u : 0u;
            this.y = v.y ? 1u : 0u;
        }

        /// <summary>Constructs a ulong2 vector from a single long value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(long v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
        }

        /// <summary>Constructs a ulong2 vector from a long2 vector by componentwise conversion.</summary>
        /// <param name="v">long2 to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(long2 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
        }

        /// <summary>Constructs a ulong2 vector from a single float value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(float v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
        }

        /// <summary>Constructs a ulong2 vector from a float2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(float2 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
        }

        /// <summary>Constructs a ulong2 vector from a single double value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(double v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
        }

        /// <summary>Constructs a ulong2 vector from a double2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to ulong2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(double2 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
        }


        /// <summary>Implicitly converts a single ulong value to a ulong2 vector by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(ulong v) { return new ulong2(v); }

        /// <summary>Explicitly converts a single bool value to a ulong2 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(bool v) { return new ulong2(v); }

        /// <summary>Explicitly converts a bool2 vector to a ulong2 vector by componentwise conversion.</summary>
        /// <param name="v">bool2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(bool2 v) { return new ulong2(v); }

        /// <summary>Explicitly converts a single long value to a ulong2 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(long v) { return new ulong2(v); }

        /// <summary>Explicitly converts a long2 vector to a ulong2 vector by componentwise conversion.</summary>
        /// <param name="v">long2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(long2 v) { return new ulong2(v); }

        /// <summary>Explicitly converts a single float value to a ulong2 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(float v) { return new ulong2(v); }

        /// <summary>Explicitly converts a float2 vector to a ulong2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(float2 v) { return new ulong2(v); }

        /// <summary>Explicitly converts a single double value to a ulong2 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(double v) { return new ulong2(v); }

        /// <summary>Explicitly converts a double2 vector to a ulong2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(double2 v) { return new ulong2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise multiplication.</param>
        /// <returns>ulong2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator * (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise multiplication.</param>
        /// <returns>ulong2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator * (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise multiplication.</param>
        /// <returns>ulong2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator * (ulong lhs, ulong2 rhs) { return new ulong2 (lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise addition.</param>
        /// <returns>ulong2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator + (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise addition.</param>
        /// <returns>ulong2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator + (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise addition.</param>
        /// <returns>ulong2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator + (ulong lhs, ulong2 rhs) { return new ulong2 (lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise subtraction.</param>
        /// <returns>ulong2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator - (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise subtraction.</param>
        /// <returns>ulong2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator - (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise subtraction.</param>
        /// <returns>ulong2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator - (ulong lhs, ulong2 rhs) { return new ulong2 (lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise division.</param>
        /// <returns>ulong2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator / (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise division.</param>
        /// <returns>ulong2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator / (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise division.</param>
        /// <returns>ulong2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator / (ulong lhs, ulong2 rhs) { return new ulong2 (lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise modulus.</param>
        /// <returns>ulong2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator % (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise modulus.</param>
        /// <returns>ulong2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator % (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise modulus.</param>
        /// <returns>ulong2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator % (ulong lhs, ulong2 rhs) { return new ulong2 (lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on a ulong2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>ulong2 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator ++ (ulong2 val) { return new ulong2 (++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on a ulong2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>ulong2 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator -- (ulong2 val) { return new ulong2 (--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise less than.</param>
        /// <returns>bool2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (ulong2 lhs, ulong2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise less than.</param>
        /// <returns>bool2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (ulong2 lhs, ulong rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise less than.</param>
        /// <returns>bool2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (ulong lhs, ulong2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise less or equal.</param>
        /// <returns>bool2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (ulong2 lhs, ulong2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise less or equal.</param>
        /// <returns>bool2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (ulong2 lhs, ulong rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise less or equal.</param>
        /// <returns>bool2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (ulong lhs, ulong2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise greater than.</param>
        /// <returns>bool2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (ulong2 lhs, ulong2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise greater than.</param>
        /// <returns>bool2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (ulong2 lhs, ulong rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise greater than.</param>
        /// <returns>bool2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (ulong lhs, ulong2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (ulong2 lhs, ulong2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise greater or equal.</param>
        /// <returns>bool2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (ulong2 lhs, ulong rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (ulong lhs, ulong2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on a ulong2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>ulong2 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator - (ulong2 val) { return new ulong2 ((ulong)-val.x, (ulong)-val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on a ulong2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>ulong2 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator + (ulong2 val) { return new ulong2 (+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise left shift operation on a ulong2 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator << (ulong2 x, int n) { return new ulong2 (x.x << n, x.y << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a ulong2 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator >> (ulong2 x, int n) { return new ulong2 (x.x >> n, x.y >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (ulong2 lhs, ulong2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (ulong2 lhs, ulong rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (ulong lhs, ulong2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (ulong2 lhs, ulong2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (ulong2 lhs, ulong rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (ulong lhs, ulong2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a ulong2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise bitwise not.</param>
        /// <returns>ulong2 result of the componentwise bitwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator ~ (ulong2 val) { return new ulong2 (~val.x, ~val.y); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise bitwise and.</param>
        /// <returns>ulong2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator & (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x & rhs.x, lhs.y & rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise and.</param>
        /// <returns>ulong2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator & (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x & rhs, lhs.y & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise bitwise and.</param>
        /// <returns>ulong2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator & (ulong lhs, ulong2 rhs) { return new ulong2 (lhs & rhs.x, lhs & rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise bitwise or.</param>
        /// <returns>ulong2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator | (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x | rhs.x, lhs.y | rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise or.</param>
        /// <returns>ulong2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator | (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x | rhs, lhs.y | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise bitwise or.</param>
        /// <returns>ulong2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator | (ulong lhs, ulong2 rhs) { return new ulong2 (lhs | rhs.x, lhs | rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two ulong2 vectors.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator ^ (ulong2 lhs, ulong2 rhs) { return new ulong2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a ulong2 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong2 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator ^ (ulong2 lhs, ulong rhs) { return new ulong2 (lhs.x ^ rhs, lhs.y ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a ulong value and a ulong2 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong2 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator ^ (ulong lhs, ulong2 rhs) { return new ulong2 (lhs ^ rhs.x, lhs ^ rhs.y); }




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



        /// <summary>Returns the ulong element at a specified index.</summary>
        unsafe public ulong this[long index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (ulong2* array = &this) { return ((ulong*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (ulong* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the ulong2 is equal to a given ulong2, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ulong2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the ulong2 is equal to a given ulong2, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is ulong2 converted && Equals(converted); }


        /// <summary>Returns a hash code for the ulong2.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the ulong2.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("ulong2({0}, {1})", x, y);
        }

        /// <summary>Returns a string representation of the ulong2 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("ulong2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public ulong x;
            public ulong y;
            public DebuggerProxy(ulong2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a ulong2 vector constructed from two ulong values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <returns>ulong2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(ulong x, ulong y) { return new ulong2(x, y); }

        /// <summary>Returns a ulong2 vector constructed from a ulong2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <returns>ulong2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(ulong2 xy) { return new ulong2(xy); }

        /// <summary>Returns a ulong2 vector constructed from a single ulong value by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(ulong v) { return new ulong2(v); }

        /// <summary>Returns a ulong2 vector constructed from a single bool value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(bool v) { return new ulong2(v); }

        /// <summary>Return a ulong2 vector constructed from a bool2 vector by componentwise conversion.</summary>
        /// <param name="v">bool2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(bool2 v) { return new ulong2(v); }

        /// <summary>Returns a ulong2 vector constructed from a single long value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(long v) { return new ulong2(v); }

        /// <summary>Return a ulong2 vector constructed from a long2 vector by componentwise conversion.</summary>
        /// <param name="v">long2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(long2 v) { return new ulong2(v); }

        /// <summary>Returns a ulong2 vector constructed from a single float value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(float v) { return new ulong2(v); }

        /// <summary>Return a ulong2 vector constructed from a float2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(float2 v) { return new ulong2(v); }

        /// <summary>Returns a ulong2 vector constructed from a single double value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(double v) { return new ulong2(v); }

        /// <summary>Return a ulong2 vector constructed from a double2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to ulong2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ulong2(double2 v) { return new ulong2(v); }

        /// <summary>Returns a ulong hash code of a ulong2 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong hash(ulong2 v)
        {
            return csum(v * ulong2(0x4473BBB1u, 0xCBA11D5Fu)) + 0x685835CFu;
        }

        /// <summary>
        /// Returns a ulong2 vector hash code of a ulong2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow ulong hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong2 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 hashwide(ulong2 v)
        {
            return (v * ulong2(0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }
    }
}