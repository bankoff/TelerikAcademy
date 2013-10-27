using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02IEnumerableExtension
{
    public static class IEnumerableExtension
    {
        public static T FindSum<T>(this IEnumerable<T> sequence)
        {
            T result = (dynamic)0;
            foreach (var element in sequence)
            {
                result += (dynamic)element;
            }
            return result;
        }

        public static T FindProduct<T>(this IEnumerable<T> sequence)
        {
            T result = (dynamic)1;
            foreach (var element in sequence)
            {
                result *= (dynamic)element;
            }
            return result;
        }

        public static T FindMin<T>(this IEnumerable<T> sequence)
        {
            //Will not work if all of the elements are bigger than int.MaxValue
            T result = (T)(dynamic)int.MaxValue;
            foreach (var element in sequence)
            {
                if (element < (dynamic)result)
                {
                    result = element;
                }
            }
            return result;
        }

        public static T FindMax<T>(this IEnumerable<T> sequence)
        {
            //Will not work if all of the elements are bigger than int.MinValue
            T result = (T)(dynamic)int.MinValue;
            foreach (var element in sequence)
            {
                if (element > (dynamic)result)
                {
                    result = element;
                }
            }
            return result;
        }

        public static T FindAverage<T>(this IEnumerable<T> sequence)
        {
            T result = (dynamic)sequence.FindSum() / (dynamic)sequence.Count();
            return result;
        }
    }
}