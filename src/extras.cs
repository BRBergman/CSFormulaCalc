using System;


public class extras
{
    public static void ask()
    {
        string[] questions= {"exit ",
        "pythagorean theorem ",
        "inverse pythagorean theorem",
        "distance formula",
        "slope formula", 
        "classify a triangle",
        "check the circumference of a circle",
        "check the area of a circle",
        "preform the midpoint formula",
        "find the area of a certan section of a circle"};// spealt wrong lol
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine("{0}. {1}",i, questions[i]);
        }
        return;
    }
    public static float[] getvars(string[] num)
    {
        int y;
        y = num.Count();
        float[] x = new float[y];
        for (int i = 0; i < y; i++)
        {
            Console.WriteLine(num[i]);
            x[i]= 0 + float.Parse(Console.ReadLine()+"");
        }
        return x;
    }
    public static void getnum()
    {
        int num = 0;
        string? str = Console.ReadLine()+"";
        if (str == "")
        {
            num = 0;
        }
        else
        {
            num = int.Parse(str);
        }
        Console.Clear();
        switch (num)
        {   
            case 1:
                mathsio.pythag(false);
                break;
            case 2:
                mathsio.pythag(true);
                break;
            case 3:
                mathsio.slop(true);
                break;
            case 4:
                mathsio.slop(false);
                break;
            case 5:
                mathsio.classifytri();
                break;
            case 6:
                mathsio.circumph(false);
                break;
            case 7:
                mathsio.circumph(true);
                break;
            case 8:
                mathsio.mid();
                break;
            case 9:
                mathsio.csar();
                break;
            default:
            return;
        }
        Console.ReadKey();
        MainClass.Calculator();
        return;
    }
}
