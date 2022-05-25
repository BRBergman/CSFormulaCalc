using System;

namespace CSFormulaCalc
{
    public class extras
    {
        public static void ask()
        {
            string[] questions= {"1. pythagorean","2. inverse pythagorean"};// spealt wrong lol
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
            }

            return;
        }
        public static int getnum()
        {
            int num;
            num = int.Parse(Console.ReadLine()+" ");
            switch (num)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                break;
            }
          

            return 0;
        }



    }
}

