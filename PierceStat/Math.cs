using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierceStat
{
    internal class Math
    {
        public static (decimal deriv, decimal offset) LeastSquared(List<decimal> xValues, List<decimal> yValues)
        {
            if(xValues.Count != yValues.Count)
            {
                throw new ArgumentException("xValue and yValue lists are different sizes");
            }
            decimal xSum = 0, ySum = 0, xySum = 0, x2Sum = 0;
            int numPoints = xValues.Count;
            for (int i = 0; i < numPoints; i++)
            {
                xSum += xValues[i];
                ySum += yValues[i];
                xySum += xValues[i] * yValues[i];
                x2Sum+= xValues[i] * xValues[i];
            }

            decimal deriv = (numPoints * xySum - xSum * ySum)/(numPoints * x2Sum - xSum * xSum);
            decimal offset = (ySum - deriv * xSum) / numPoints;

            return (deriv, offset);
        }
    }
}
