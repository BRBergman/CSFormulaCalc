using System;




Console.WriteLine(CSFormulaCalc.Maths.distance(1,1,2,2));
double pythag1 = CSFormulaCalc.Maths.pythagorean(3,4);

Console.WriteLine(pythag1);
Console.WriteLine();
namespace CSFormulaCalc
{
    
    class Name
    {
        public string ?thename;
        public string getname()
        {
            Console.WriteLine("What is your name?");
            thename = Console.ReadLine()+" ";

            return thename;
        } 
       public void sayname()
       {
           Console.WriteLine($"Oh your name is {thename}? Thats cool.");
           return;
       }
    }
}

