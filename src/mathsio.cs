using System;

namespace CSFormulaCalc
{
    public class mathsio
    {
        public static void pythag(bool inverse)
        {
           
            string[] str = {"what is your x", "what is your y"};
            float[] x = (CSFormulaCalc.extras.getvars(str));
            double ans = new double();
            if (inverse)
            {
                ans = CSFormulaCalc.Formulas.ReversePythagorean(x[0],x[1]);
            }
            else
            {
                ans = CSFormulaCalc.Formulas.Pythagorean(x[0],x[1]);
            }
            Console.WriteLine(ans);
            return;
        }
    }
}