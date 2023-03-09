using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpLib
{
   public class MathComponent
    {
        public double AddFunc(double v1, double v2) => v1 + v2;
        public double SubFunc(double v1, double v2) => v1 - v2;
        public double MulFunc(double v1, double v2) => v1 * v2;
        public double DivFunc(double v1, double v2) => v1 / v2;
        public double Square(double v1) => MulFunc(v1, v1);
        public double SquareRoot(double v1) => Math.Sqrt(v1);
    }
}
