using System;


public class mathsio
{
    public static void csar()
    {
        string[] str =  {"Enter Radius: ","Enter Angle: "};
        float[] x = extras.getvars(str);
        Console.WriteLine("The Area Is: {0}", Formulas.CSArea(x[0],x[1]));
        return;
    }
    
    public static void mid()
    {
        string[] str =  {"Enter X1: ","Enter X2: ","Enter Y1: ","Enter Y2: "};
        float[] x = extras.getvars(str);
        double[] num = Formulas.Midpoint(x[0],x[1],x[2],x[3]);
        Console.WriteLine("The Midpoint Is: {0},{1}",num[0],num[1]);
        return;
    }

    public static void circumph(bool area)	//if true does area if false does circumphrince
    {
        string[] str =  {"Enter The Radius: "};
        float[] x = extras.getvars(str);            
        if (area)
        {
            Console.WriteLine("The Area Is: {0}", Formulas.CArea(x[0]));
        }
        else
        {
            Console.WriteLine("The Circumference Is: {0}",Formulas.Circumprence(x[0]));
        }
        return;
    }

    public static void classifytri()
    {
        string[] str = {"Enter A: ","Enter B: ","Enter C: "};
        string[] tri = {"It's Not A Triangle","It's A Right Triangle","It's An Obtuse Triangle","It's An Accute Triangle"};
        float[] x = extras.getvars(str);
        int cases = Formulas.CheckIfTri(x[0],x[1],x[2]);
        Console.WriteLine(tri[cases]);
        return;
    }
    public static void slop(bool dist) //true distance formula false slope formula   
    {
        string[] str = {"Enter X1: ","Enter Y1: ","Enter X2: ","Enter Y2: "};
        float[] x = extras.getvars(str);
        if (dist)
        {
            Console.WriteLine( "The Distance is : {0}",Formulas.Distance(x[0],x[1],x[2],x[3]));
        }
        else
        {
            Console.WriteLine( "The Slope Is: {0}",Formulas.Slope(x[0],x[1],x[2],x[3]));
        }
        return;
    }
    public static void pythag(bool inverse)
    {
        string[] str = {"What Is Your X", "What Is Your Y"};
        float[] x = extras.getvars(str);
        if (inverse)
        {
            Console.WriteLine("The Leg Is: {0}",Formulas.ReversePythagorean(x[0],x[1]));   
        }
        else
        {
            Console.WriteLine( "The Hypotenuse Is: {0}", Formulas.Pythagorean(x[0],x[1]));
        }
        return;
    }
}
