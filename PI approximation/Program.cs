using System;
using System.Collections;

namespace PI_approximation
{
    public class PiApprox
    {
        public static ArrayList IterPi(double epsilon)
        {
            double iter = 1 / epsilon;
            double pi = 0;
            double sign = 1;

            for (double i = 0; i < 1 / epsilon; i++)
            {
                pi += sign / (2 * i + 1);
                sign = -sign;
            }
            double resPI = 4 * pi;
            double er = Math.Round(resPI, 10);
            ArrayList res = new ArrayList() { iter, er };
            return res;
        }
    }    
}