﻿using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Unity.Mathematics.Extensions
{
    /// <summary>A 4 component vector of ulongs.</summary>
    [DebuggerTypeProxy(typeof(ulong4.DebuggerProxy))]
    [System.Serializable]
    public partial struct ulong4 : System.IEquatable<ulong4>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public ulong x;
        /// <summary>y component of the vector.</summary>
        public ulong y;
        /// <summary>z component of the vector.</summary>
        public ulong z;
        /// <summary>w component of the vector.</summary>
        public ulong w;

        /// <summary>ulong4 zero value.</summary>
        public static readonly ulong4 zero;

        /// <summary>Constructs a ulong4 vector from four ulong values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong y, ulong z, ulong w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a ulong4 vector from two ulong values and a ulong2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong y, ulong2 zw)
        {
            this.x = x;
            this.y = y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a ulong4 vector from a ulong value, a ulong2 vector and a ulong value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong2 yz, ulong w)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a ulong4 vector from a ulong value and a ulong3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong x, ulong3 yzw)
        {
            this.x = x;
            this.y = yzw.x;
            this.z = yzw.y;
            this.w = yzw.z;
        }

        /// <summary>Constructs a ulong4 vector from a ulong2 vector and two ulong values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong2 xy, ulong z, ulong w)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a ulong4 vector from two ulong2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong2 xy, ulong2 zw)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a ulong4 vector from a ulong3 vector and a ulong value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong3 xyz, ulong w)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a ulong4 vector from a ulong4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong4 xyzw)
        {
            this.x = xyzw.x;
            this.y = xyzw.y;
            this.z = xyzw.z;
            this.w = xyzw.w;
        }

        /// <summary>Constructs a ulong4 vector from a single ulong value by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(ulong v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a ulong4 vector from a single bool value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(bool v)
        {
            this.x = v ? 1u : 0u;
            this.y = v ? 1u : 0u;
            this.z = v ? 1u : 0u;
            this.w = v ? 1u : 0u;
        }

        /// <summary>Constructs a ulong4 vector from a bool4 vector by componentwise conversion.</summary>
        /// <param name="v">bool4 to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(bool4 v)
        {
            this.x = v.x ? 1u : 0u;
            this.y = v.y ? 1u : 0u;
            this.z = v.z ? 1u : 0u;
            this.w = v.w ? 1u : 0u;
        }

        /// <summary>Constructs a ulong4 vector from a single long value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(long v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
            this.z = (ulong)v;
            this.w = (ulong)v;
        }

        /// <summary>Constructs a ulong4 vector from a long4 vector by componentwise conversion.</summary>
        /// <param name="v">long4 to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(long4 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
            this.z = (ulong)v.z;
            this.w = (ulong)v.w;
        }

        /// <summary>Constructs a ulong4 vector from a single float value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(float v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
            this.z = (ulong)v;
            this.w = (ulong)v;
        }

        /// <summary>Constructs a ulong4 vector from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(float4 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
            this.z = (ulong)v.z;
            this.w = (ulong)v.w;
        }

        /// <summary>Constructs a ulong4 vector from a single double value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(double v)
        {
            this.x = (ulong)v;
            this.y = (ulong)v;
            this.z = (ulong)v;
            this.w = (ulong)v;
        }

        /// <summary>Constructs a ulong4 vector from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to ulong4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4(double4 v)
        {
            this.x = (ulong)v.x;
            this.y = (ulong)v.y;
            this.z = (ulong)v.z;
            this.w = (ulong)v.w;
        }


        /// <summary>Implicitly converts a single ulong value to a ulong4 vector by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(ulong v) { return new ulong4(v); }

        /// <summary>Explicitly converts a single bool value to a ulong4 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(bool v) { return new ulong4(v); }

        /// <summary>Explicitly converts a bool4 vector to a ulong4 vector by componentwise conversion.</summary>
        /// <param name="v">bool4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(bool4 v) { return new ulong4(v); }

        /// <summary>Explicitly converts a single long value to a ulong4 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(long v) { return new ulong4(v); }

        /// <summary>Explicitly converts a long4 vector to a ulong4 vector by componentwise conversion.</summary>
        /// <param name="v">long4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(long4 v) { return new ulong4(v); }

        /// <summary>Explicitly converts a single float value to a ulong4 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(float v) { return new ulong4(v); }

        /// <summary>Explicitly converts a float4 vector to a ulong4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(float4 v) { return new ulong4(v); }

        /// <summary>Explicitly converts a single double value to a ulong4 vector by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(double v) { return new ulong4(v); }

        /// <summary>Explicitly converts a double4 vector to a ulong4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(double4 v) { return new ulong4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise multiplication.</param>
        /// <returns>ulong4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator * (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise multiplication.</param>
        /// <returns>ulong4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator * (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise multiplication.</param>
        /// <returns>ulong4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator * (ulong lhs, ulong4 rhs) { return new ulong4 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise addition.</param>
        /// <returns>ulong4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator + (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise addition.</param>
        /// <returns>ulong4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator + (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise addition.</param>
        /// <returns>ulong4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator + (ulong lhs, ulong4 rhs) { return new ulong4 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise subtraction.</param>
        /// <returns>ulong4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator - (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise subtraction.</param>
        /// <returns>ulong4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator - (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise subtraction.</param>
        /// <returns>ulong4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator - (ulong lhs, ulong4 rhs) { return new ulong4 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise division.</param>
        /// <returns>ulong4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator / (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise division.</param>
        /// <returns>ulong4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator / (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise division.</param>
        /// <returns>ulong4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator / (ulong lhs, ulong4 rhs) { return new ulong4 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise modulus.</param>
        /// <returns>ulong4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator % (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise modulus.</param>
        /// <returns>ulong4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator % (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise modulus.</param>
        /// <returns>ulong4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator % (ulong lhs, ulong4 rhs) { return new ulong4 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise increment operation on a ulong4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>ulong4 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator ++ (ulong4 val) { return new ulong4 (++val.x, ++val.y, ++val.z, ++val.w); }


        /// <summary>Returns the result of a componentwise decrement operation on a ulong4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>ulong4 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator -- (ulong4 val) { return new ulong4 (--val.x, --val.y, --val.z, --val.w); }


        /// <summary>Returns the result of a componentwise less than operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator < (ulong4 lhs, ulong4 rhs) { return new bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator < (ulong4 lhs, ulong rhs) { return new bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator < (ulong lhs, ulong4 rhs) { return new bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <= (ulong4 lhs, ulong4 rhs) { return new bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <= (ulong4 lhs, ulong rhs) { return new bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <= (ulong lhs, ulong4 rhs) { return new bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator > (ulong4 lhs, ulong4 rhs) { return new bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator > (ulong4 lhs, ulong rhs) { return new bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator > (ulong lhs, ulong4 rhs) { return new bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >= (ulong4 lhs, ulong4 rhs) { return new bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >= (ulong4 lhs, ulong rhs) { return new bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >= (ulong lhs, ulong4 rhs) { return new bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on a ulong4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>ulong4 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator - (ulong4 val) { return new ulong4 ((ulong)-val.x, (ulong)-val.y, (ulong)-val.z, (ulong)-val.w); }


        /// <summary>Returns the result of a componentwise unary plus operation on a ulong4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>ulong4 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator + (ulong4 val) { return new ulong4 (+val.x, +val.y, +val.z, +val.w); }


        /// <summary>Returns the result of a componentwise left shift operation on a ulong4 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator << (ulong4 x, int n) { return new ulong4 (x.x << n, x.y << n, x.z << n, x.w << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a ulong4 vector by a number of bits specified by a single long.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator >> (ulong4 x, int n) { return new ulong4 (x.x >> n, x.y >> n, x.z >> n, x.w >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (ulong4 lhs, ulong4 rhs) { return new bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (ulong4 lhs, ulong rhs) { return new bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (ulong lhs, ulong4 rhs) { return new bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (ulong4 lhs, ulong4 rhs) { return new bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (ulong4 lhs, ulong rhs) { return new bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (ulong lhs, ulong4 rhs) { return new bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a ulong4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise bitwise not.</param>
        /// <returns>ulong4 result of the componentwise bitwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator ~ (ulong4 val) { return new ulong4 (~val.x, ~val.y, ~val.z, ~val.w); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise bitwise and.</param>
        /// <returns>ulong4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator & (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise and.</param>
        /// <returns>ulong4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator & (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise bitwise and.</param>
        /// <returns>ulong4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator & (ulong lhs, ulong4 rhs) { return new ulong4 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise bitwise or.</param>
        /// <returns>ulong4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator | (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise or.</param>
        /// <returns>ulong4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator | (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise bitwise or.</param>
        /// <returns>ulong4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator | (ulong lhs, ulong4 rhs) { return new ulong4 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two ulong4 vectors.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator ^ (ulong4 lhs, ulong4 rhs) { return new ulong4 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a ulong4 vector and a ulong value.</summary>
        /// <param name="lhs">Left hand side ulong4 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator ^ (ulong4 lhs, ulong rhs) { return new ulong4 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a ulong value and a ulong4 vector.</summary>
        /// <param name="lhs">Left hand side ulong to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side ulong4 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>ulong4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 operator ^ (ulong lhs, ulong4 rhs) { return new ulong4 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w); }




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
        public ulong4 xxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, x, w); }
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
        public ulong4 xxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, y, w); }
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
        public ulong4 xxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, x, w, w); }
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
        public ulong4 xyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, x, w); }
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
        public ulong4 xyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, y, w); }
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
        public ulong4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, y, w, w); }
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
        public ulong4 xzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, x, w); }
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
        public ulong4 xzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
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
        public ulong4 xzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 xwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(x, w, w, w); }
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
        public ulong4 yxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, x, w); }
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
        public ulong4 yxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, y, w); }
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
        public ulong4 yxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, x, w, w); }
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
        public ulong4 yyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, x, w); }
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
        public ulong4 yyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, y, w); }
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
        public ulong4 yyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, y, w, w); }
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
        public ulong4 yzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
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
        public ulong4 yzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, y, w); }
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
        public ulong4 yzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 yzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 ywww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(y, w, w, w); }
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
        public ulong4 zxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, x, w); }
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
        public ulong4 zxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
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
        public ulong4 zxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, x, w, w); }
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
        public ulong4 zyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
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
        public ulong4 zyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, y, w); }
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
        public ulong4 zyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, y, w, w); }
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
        public ulong4 zzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, x, w); }
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
        public ulong4 zzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, y, w); }
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
        public ulong4 zzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 zwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(z, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong4 wwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong4(w, w, w, w); }
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
        public ulong3 xxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, x, w); }
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
        public ulong3 xyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; }
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
        public ulong3 xzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 xww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(x, w, w); }
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
        public ulong3 yxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; }
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
        public ulong3 yyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, y, w); }
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
        public ulong3 yzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 ywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 ywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 ywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 yww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(y, w, w); }
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
        public ulong3 zxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; }
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
        public ulong3 zyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; }
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
        public ulong3 zzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 zww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 wwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong3 www
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong3(w, w, w); }
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
        public ulong2 xw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; }
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
        public ulong2 yw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; }
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


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 zw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 wx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 wy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 wz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ulong2 ww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new ulong2(w, w); }
        }



        /// <summary>Returns the ulong element at a specified index.</summary>
        unsafe public ulong this[long index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (ulong4* array = &this) { return ((ulong*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((ulong)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (ulong* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the ulong4 is equal to a given ulong4, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ulong4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the ulong4 is equal to a given ulong4, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is ulong4 converted && Equals(converted); }


        /// <summary>Returns a hash code for the ulong4.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the ulong4.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("ulong4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        /// <summary>Returns a string representation of the ulong4 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("ulong4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public ulong x;
            public ulong y;
            public ulong z;
            public ulong w;
            public DebuggerProxy(ulong4 v)
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
        /// <summary>Returns a ulong4 vector constructed from four ulong values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong x, ulong y, ulong z, ulong w) { return new ulong4(x, y, z, w); }

        /// <summary>Returns a ulong4 vector constructed from two ulong values and a ulong2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong x, ulong y, ulong2 zw) { return new ulong4(x, y, zw); }

        /// <summary>Returns a ulong4 vector constructed from a ulong value, a ulong2 vector and a ulong value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong x, ulong2 yz, ulong w) { return new ulong4(x, yz, w); }

        /// <summary>Returns a ulong4 vector constructed from a ulong value and a ulong3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong x, ulong3 yzw) { return new ulong4(x, yzw); }

        /// <summary>Returns a ulong4 vector constructed from a ulong2 vector and two ulong values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong2 xy, ulong z, ulong w) { return new ulong4(xy, z, w); }

        /// <summary>Returns a ulong4 vector constructed from two ulong2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong2 xy, ulong2 zw) { return new ulong4(xy, zw); }

        /// <summary>Returns a ulong4 vector constructed from a ulong3 vector and a ulong value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong3 xyz, ulong w) { return new ulong4(xyz, w); }

        /// <summary>Returns a ulong4 vector constructed from a ulong4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        /// <returns>ulong4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong4 xyzw) { return new ulong4(xyzw); }

        /// <summary>Returns a ulong4 vector constructed from a single ulong value by assigning it to every component.</summary>
        /// <param name="v">ulong to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(ulong v) { return new ulong4(v); }

        /// <summary>Returns a ulong4 vector constructed from a single bool value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">bool to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(bool v) { return new ulong4(v); }

        /// <summary>Return a ulong4 vector constructed from a bool4 vector by componentwise conversion.</summary>
        /// <param name="v">bool4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(bool4 v) { return new ulong4(v); }

        /// <summary>Returns a ulong4 vector constructed from a single long value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">long to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(long v) { return new ulong4(v); }

        /// <summary>Return a ulong4 vector constructed from a long4 vector by componentwise conversion.</summary>
        /// <param name="v">long4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(long4 v) { return new ulong4(v); }

        /// <summary>Returns a ulong4 vector constructed from a single float value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">float to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(float v) { return new ulong4(v); }

        /// <summary>Return a ulong4 vector constructed from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(float4 v) { return new ulong4(v); }

        /// <summary>Returns a ulong4 vector constructed from a single double value by converting it to ulong and assigning it to every component.</summary>
        /// <param name="v">double to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(double v) { return new ulong4(v); }

        /// <summary>Return a ulong4 vector constructed from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to ulong4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ulong4(double4 v) { return new ulong4(v); }

        /// <summary>Returns a ulong hash code of a ulong4 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong hash(ulong4 v)
        {
            return csum(v * ulong4(0xB492BF15u, 0xD37220E3u, 0x7AA2C2BDu, 0xE16BC89Du)) + 0x7AA07CD3u;
        }

        /// <summary>
        /// Returns a ulong4 vector hash code of a ulong4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow ulong hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>ulong4 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 hashwide(ulong4 v)
        {
            return (v * ulong4(0xAF642BA9u, 0xA8F2213Bu, 0x9F3FDC37u, 0xAC60D0C3u)) + 0x9263662Fu;
        }
    }
}