using System;

namespace CSFormulaCalc
{
    public class extras
    {
        public static void ask()
        {
            string[] questions= {"pythagorean","inverse pythagorean"};// spealt wrong lol
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i+1, questions[i]);
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
                x[i]= float.Parse(Console.ReadLine()+ "");
            }

            return x;
        }
        public static int getnum()
        {
            int num;
            num = int.Parse(Console.ReadLine()+" ");
            switch (num)
            {
                case 1:
                    mathsio.pythag(false);
                    break;
                case 2:
                    mathsio.pythag(true);
                    break;
                default:
                break;
            }
            return 0;
        }
    }
}

