using System;

namespace CSFormulaCalc
{
    public class mathsio
    {
        public static void pythag(bool inverse)
        {
           
            string[] str = {"what is your x", "what is your y"};
            float[] x = (CSFormulaCalc.extras.getvars(str));
            if (inverse)
            {
              Console.WriteLine("The Leg is: {0}",CSFormulaCalc.Formulas.ReversePythagorean(x[0],x[1]));   
            }
            else
            {
                Console.WriteLine( "The Hypotenuse is: {0}", CSFormulaCalc.Formulas.Pythagorean(x[0],x[1]));
            }
            return;
        }
    }
}