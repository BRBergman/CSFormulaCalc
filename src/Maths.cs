using System;

namespace CSFormulaCalc
{
    public class Invert
    {
        public static int InvertI(int InvertThis)
        {
            return InvertThis*-1;
        }
        public static float InvertF(float InvertThis)
        {
            return InvertThis*-1;
        }
        public static double InvertD(double InvertThis)
        {
            return InvertThis*-1;
        }
        
    }
    public class Formulas
    {
        public static double Distance(float x1,float y1,float x2,float y2)
        {
	        //distance formula
	        return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        }

        public static double Slope(float x1,float y1,float x2,float y2)
        {
            //slope formula
            return (y2-y1)/(x2-x1);
        }


        public static double Pythagorean(float a, float b)
        {
            //a2+b2=c2
            return Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
        }

        public static double ReversePythagorean(float b, float c)
        {	
            //c2-b2=a2
            return Math.Sqrt(Math.Pow(c,2) - Math.Pow(b,2));
        }


        public static int CheckIfTri(float a, float b, float c)
        {
            // make a case on output so that is does the good
            if(c >= (a+b))
            {
                return 0;
            }
            double a2 = Math.Pow(a,2);
            double b2 = Math.Pow(b,2);
            double c2 = Math.Pow(c,2);
            if (c2 == a2+b2)
            {
                //right
                return 1;
            }
            if (c2 > a2+b2)
            {
                //obtuse
                return 2;
            }
            if (c2 < a2+b2)
            {
                //accute
                return 3;
            }
            
            return 0;
        }
        public static double Circumprence(float rad)
        {
            return Math.PI*(rad*2);
        }

        public static double CArea(float rad)
        {
            return Math.PI*Math.Pow(rad, 2);
        }

        public static double[] Midpoint(float x1, float x2, float y1, float y2)
        {
            double[] x = {(x1+x2)/2, (y1+y2)/2};
            
            return x;
        }

        //circle section area
        public static double CSArea(float radious, float angle)
        {
            double top = angle*(Math.PI*Math.Pow(radious,2));

            return top/360;
        }
    }
}
