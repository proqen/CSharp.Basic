using System;

namespace Task9._2
{
    
    public delegate string CalcDelegate(double a, double b);

    class Program { 
        static void Main(string[] args)
        {

            CalcDelegate add = (a, b) => (a + b).ToString();
            CalcDelegate sub = (a, b) => (a - b).ToString();    
            CalcDelegate mul = (a, b) => (a * b).ToString();
            CalcDelegate div = (a, b) => b == 0 ? "На ноль делить нельзя!" : (a / b).ToString();

            int a = 12, b = 3;
            char oper = '/'; //+-*/

            var res = oper switch
            {
                '+' => add(a ,b),
                '-' => sub(a, b),
                '*' => mul(a, b),
                '/' => div(a, b),
                _ => "Error"
            };

            Console.WriteLine(res);
        }
    }
}
