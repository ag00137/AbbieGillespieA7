using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbieGillespieA7.CarObject;

namespace AbbieGillespieA7.Comparers
{
    /// <summary>
    /// Class that sorts the make and price of the car.
    /// </summary>
    public class MakeAndPriceComparer : IComparer<Car>
    {
        /// <summary>
        /// Compares two objects and returns the comparison list.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>
        /// the comparison list
        /// </returns>
        public int Compare(Car x, Car y)
        {
            if (x == null || y == null) return 0;

            int comparison = x.Make.CompareTo(y.Make);

            if (comparison == 0)
            {
                return x.Price.CompareTo(y.Price);
            }
            return comparison;
        }
    }
}
