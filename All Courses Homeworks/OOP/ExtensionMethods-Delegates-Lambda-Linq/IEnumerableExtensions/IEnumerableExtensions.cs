namespace IEnumerableExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        public static ulong Sum<T>(this IEnumerable<T> enumeration)
        {
            ulong result = 0;
            foreach (var item in enumeration)
            {
                result += Convert.ToUInt64(item);
            }
            return result;
        }

        public static ulong Product<T>(this IEnumerable<T> enumeration)
        {
            ulong result = 1;
            foreach (var item in enumeration)
            {
                result *= Convert.ToUInt64(item);
            }
            return result;
        }

        public static ulong Min<T>(this IEnumerable<T> enumeration) where T: IComparable
        {
            ulong min = int.MaxValue;
            foreach (var item in enumeration)
            {
                ulong current = Convert.ToUInt64(item);
                if (current.CompareTo(min) <= 0)
                {
                    min = Convert.ToUInt64(item);
                }
            }
            return min;
        }

        public static ulong Max<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            ulong max = ulong.MinValue;
            foreach (var item in enumeration)
            {
                ulong current = Convert.ToUInt64(item);
                if (current.CompareTo(max) >= 0)
                {
                    max = Convert.ToUInt64(item);
                }
            }
            return max;
        }
        public static ulong Average<T>(this IEnumerable<T> enumeration)
        {
            ulong result = 0;
            foreach (var item in enumeration)
            {
                result += Convert.ToUInt64(item);
            }
            return result / 2;
        }
    }
}
