using System;

namespace CSFormulaCalc
{
    public class mathsio
    {
        public static void csar()
        {
            string[] str =  {"Enter Radious: ","Enter Angle: "};
            float[] x = CSFormulaCalc.extras.getvars(str);
            Console.WriteLine("The Area is: {0}", CSFormulaCalc.Formulas.CSArea(x[0],x[1]));
            return;
        }

        public static void mid()
        {
            string[] str =  {"Enter X1: ","Enter X2: ","Enter Y1: ","Enter Y2: "};
            float[] x = CSFormulaCalc.extras.getvars(str);
            double[] num = CSFormulaCalc.Formulas.Midpoint(x[0],x[1],x[2],x[3]);
            Console.WriteLine("the midpoint is: {1},{2}",num[0],num[1]);
            return;
        }

        public static void circumph(bool area)	//if true does area if false does circumphrince
        {
            string[] str =  {"Enter the Radious: "};
            float[] x = CSFormulaCalc.extras.getvars(str);            
            if (area)
            {
                Console.WriteLine("The area is: {0}", CSFormulaCalc.Formulas.CArea(x[0]));
            }
            else
            {
                Console.WriteLine("The Circumference is: {0}",CSFormulaCalc.Formulas.Circumprence(x[0]));
            }
            return;
        }

        public static void classifytri()
        {
            string[] str = {"Enter A: ","Enter B: ","Enter C: "};
            string[] tri = {"It's not a triangle","It's a right triangle","It's an obtuse triangle","It's an accute triangle"};
            float[] x = CSFormulaCalc.extras.getvars(str);
            int cases = CSFormulaCalc.Formulas.CheckIfTri(x[0],x[1],x[2]);
            Console.WriteLine(tri[cases]);
            return;
        }
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