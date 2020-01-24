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

        //nahrazeno generickým delegátem Func<T, double>
        //public delegate double GetWeight<T>(T dite);

    }
}
