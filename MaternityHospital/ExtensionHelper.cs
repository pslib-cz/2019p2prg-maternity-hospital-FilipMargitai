using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityHospital.Linq
{
    static class ExtensionHelper
    {
        public static double Avg<T>(this IEnumerable<T> kolekce, /*GetWeight<T>*/ Func<T, double> getWeight)
        {
            double suma = 0;
            int count = 0;
            foreach (var detatko in kolekce)
            {
                count++;
                suma += getWeight(detatko);

            }
            return suma / count;
        }

        public static string Join<T>(this IEnumerable<T> enumerable, string separator)
        {
            var enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            enumerator.MoveNext();
            var result = enumerator.Current?.ToString() ?? "";

            while (enumerator.MoveNext())
            {
                result += separator + enumerator.Current?.ToString();
            }
            enumerator.Dispose();

            return result;
        }

        public static string Join<T>(this IEnumerable<T> enumerable, string separator, Func<T,string> mapping)
        {
            IEnumerator<T> enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            enumerator.MoveNext();
            
            string result = mapping(enumerator.Current) ?? "";

            while (enumerator.MoveNext())
            {
                result += separator + mapping(enumerator.Current);
            }
            enumerator.Dispose();

            return result;
        }

        //nahrazeno generickým delegátem Func<T, double>
        //public delegate double GetWeight<T>(T dite);

    }
}
