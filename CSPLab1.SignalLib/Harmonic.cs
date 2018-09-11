using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPLab1.SignalLib
{
    public static class Harmonic 
    {

        static Harmonic()
        {
            
        }
        public static double Calc(int a, int N, int n, double fi, int f, int k)
        {

            return a * Math.Sin(2 * Math.PI * f * n / N + fi);
        }
    }
}
