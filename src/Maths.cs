using System;

namespace CSFormulaCalc
{
    public class Maths
    {
        public static double distance(float x1,float y1,float x2,float y2)
        {
	        //distance formula
	        return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        }

        public static double slope(float x1,float y1,float x2,float y2)
        {
            //slope formula
            return (y2-y1)/(x2-x1);
        }


        public static double pythagorean(float a, float b)
        {
            //a2+b2=c2
            return Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
        }

        public static double reversepythagorean(float b, float c)
        {	
            //c2-b2=a2
            return Math.Sqrt(Math.Pow(c,2) - Math.Pow(b,2));
        }

        public static double quadperm(float x1,float y1,float x2,float y2, float x3,float y3,float x4,float y4)
        {
            //top and bottom
            double d1 = distance(x1,y1,x2,y2);
            double d2 = distance(x3,y3,x4,y4);
            //sides
            double d3 = distance(x2,y2,x3,y3);
            double d4 = distance(x4,y4,x1,y1);

            return (d1+d2+d3+d4);
        }

        public static int cheiftr(float a, float b, float c)
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
        public static double circ(float rad)
        {
            return Math.PI*(rad*2);
        }

        public static double carea(float rad)
        {
            return Math.PI*Math.Pow(rad, 2);
        }

        public static double midpoint(float one, float two)
        {
            //do twice to get x and y

            return (one+two)/2;
        }
        
        public static double csaria(float radious, float angle)
        {
            double top = angle*(Math.PI*Math.Pow(radious,2));

            return top/360;
        }
    }
}
