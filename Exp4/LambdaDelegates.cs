using System;
using System.Collections.Generic;
using System.Text;

namespace Exp4
{
    public class LambdaDelegates
    {
        //single casting
        public delegate void displayNumber(int num);

        //multi casting
        public delegate void operations(int a,int b);

        public static void lambdaDelegate()
        {
            //single cast with lambda
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            displayNumber number = (num) => System.Console.WriteLine("Number = " + num);
            number(num);

            //multi casting with lambda
            Console.WriteLine("Enter 1st Integer:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Integer:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            operations oprs = (num1,num2) => System.Console.WriteLine("Addition = " + (num1 + num2));
            oprs += (num1,num2) => System.Console.WriteLine("Substraction = " + (num1 - num2));
            oprs += (num1, num2) => System.Console.WriteLine("Multiplication = " + (num1 * num2));
            oprs += (num1, num2) => System.Console.WriteLine("Division = " + (num1 / num2));
            oprs(n1,n2);
        }

    }
}
