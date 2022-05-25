using System;

namespace CSFormulaCalc
{
    public class mathsio
    {

        public static void slop(bool dist) //true distance formula false slope formula   
        {
            
            string[] str = {"Enter X1: ","Enter Y1: ","Enter X2: ","Enter Y2: "};
            float[] x = CSFormulaCalc.extras.getvars(str);

            
            if (dist)
            {
                
               Console.WriteLine( CSFormulaCalc.Formulas.Distance(x[0],x[1],x[2],x[3]));
            }
            else
            {
                Console.WriteLine( CSFormulaCalc.Formulas.Slope(x[0],x[1],x[2],x[3]));
            }

            return;
        }
        public static void pythag(bool inverse)
        {
           
            string[] str = {"what is your x", "what is your y"};
            float[] x = CSFormulaCalc.extras.getvars(str);
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