namespace IEnumerable.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {

        public static void EmptyCheck<T>(IEnumerable<T> collection)
        {
            if (collection.Count() <= 0 )
            {
                throw new IndexOutOfRangeException();
            }
        }

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            EmptyCheck((dynamic)collection);

            T result = default(T);
            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            EmptyCheck((dynamic)collection);

            T result = (dynamic)1;
            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            EmptyCheck((dynamic)collection);

            T max = collection.FirstOrDefault();

            foreach (var num in collection)
            {
                if ((dynamic)max < num)
                {
                    max = num;
                }
            }

            return max;
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            EmptyCheck((dynamic)collection);

            T min = collection.FirstOrDefault();

            foreach (var num in collection)
            {
                if ((dynamic)min > num)
                {
                    min = num;
                }
            }

            return min;
        }

        public static double Average<T>(this IEnumerable<T> collection)
        {
            EmptyCheck((dynamic)collection);

            T sum = collection.Sum();
            double result = 0.0;
            result = (dynamic)sum / (double)collection.Count();
            return result;
        }
    }
}
