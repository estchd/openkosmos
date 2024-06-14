using System;
using System.Runtime.CompilerServices;
using Unity.Burst;

namespace Unity.Mathematics.Extensions
{
    [BurstCompile]
    public partial struct double_quaternion : System.IEquatable<double_quaternion>, IFormattable
    {
        public double4 Value;

        public static readonly double_quaternion Identity = new double_quaternion(0.0, 0.0, 0.0, 0.0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double_quaternion(double x, double y, double z, double w)
        {
            this.Value.x = x;
            this.Value.y = y;
            this.Value.z = z;
            this.Value.w = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double_quaternion(double4 value)
        {
            this.Value = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double_quaternion(double4 v)
        {
            return new double_quaternion(v);
        }

        public double_quaternion(double3x3 m)
        {
            double3 u = m.c0;
            double3 v = m.c1;
            double3 w = m.c2;

            ulong u_sign = math.asulong(u.x) & 0x8000000000000000;
            double t = v.y + math.asdouble(math.asulong(w.z) ^ u_sign);
            
        }
        
        public bool Equals(double_quaternion other)
        {
            throw new NotImplementedException();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}