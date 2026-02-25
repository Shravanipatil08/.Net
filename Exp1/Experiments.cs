using Exp1;
using System;
using System.Collections.Generic;
using System.Text;

class Experiments
{
    public static void showExp()
    {
        //variables
        int myNum = 15;
        myNum = 20;
        Console.WriteLine(myNum);

        //multiple variables
        int x, y, z;
        x = y = z = 50;
        Console.WriteLine(x + y + z);

        //Data types
        long myNum2 = 15000000000L;
        Console.WriteLine(myNum2);

        float myNum3 = 5.75F;
        Console.WriteLine(myNum3);

        float myNum4 = 5.75F;
        Console.WriteLine(myNum4);

        bool isCSharpFun = true;
        Console.WriteLine(isCSharpFun);

        char myGrade = 'B';
        Console.WriteLine(myGrade);

        string greeting = "Hello World";
        Console.WriteLine(greeting);

        //Implicit type casting
        int myInt = 9;
        double myDouble = myInt;

        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);

        //Explicit type casting
        double myDoubleNo = 9.78;
        int myIntNo = (int)myDoubleNo;

        Console.WriteLine(myDouble);
        Console.WriteLine(myInt);

        //Type conversion methods
        int myIntNo1 = 10;
        double myDoubleNo1 = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myIntNo1));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myIntNo1));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDoubleNo1));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

        //User Input
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);

        //Taking int as a input
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);

        //Math
        Console.WriteLine(Math.Max(5, 10));
        Console.WriteLine(Math.Min(5, 10));
        Console.WriteLine(Math.Sqrt(5));
        Console.WriteLine(Math.Abs(-30));
        Console.WriteLine(Math.Round(8.7));

        //Strings
        string greeting2 = "Nice to meet you!";
        Console.WriteLine(greeting2);
        Console.WriteLine("Length of Greeting:" + greeting2.Length);

        Console.WriteLine(greeting2.ToUpper());
        Console.WriteLine(greeting2.ToLower());

        //Concatination
        string firstName = "John ";
        string lastName = "Doe";
        string name = firstName + lastName;
        Console.WriteLine(name);

        //String Interpolation
        string firstName1 = "John";
        string lastName1 = "Doe";
        string name1 = $"My full name is: {firstName1} {lastName1}";
        Console.WriteLine(name1);

        //Accesing String
        string myString = "Hello";
        Console.WriteLine(myString[1]);

        //Special Characters
        string txt = "We are the so-called \"Vikings\" from the north.";
        Console.WriteLine(txt);

        //If-Else
        int time = 20;
        if (time < 18)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        //Else IF
        int time2 = 22;
        if (time2 < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time2 < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        //Short hand if else
        Console.WriteLine("Enter Age to Check:");
        int newAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Person is " + (newAge > 18 ? "Adult" : "Not Adult"));

        //Switch Case
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }

        //While Loop
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }

        //Do While loop
        int i1 = 0;
        do
        {
            Console.WriteLine(i);
            i1++;
        }
        while (i1 < 5);

        //For loop
        for (int i3 = 0; i3 <= 10; i3 = i3 + 2)
        {
            Console.WriteLine(i3);
        }


        //For Each loop
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i4 in cars)
        {
            Console.WriteLine(i4);
        }

        //Break 
        for (int i5 = 0; i5 < 10; i5++)
        {
            if (i5 == 4)
            {
                break;
            }
            Console.WriteLine(i5);
        }

        //Continue
        for (int i6 = 0; i6 < 10; i6++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        //Arrays
        string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars2[0]);
        cars2[0] = "Opel";
        Console.WriteLine(cars2[0]);

        //Sort Array
        int[] myNumbers = { 5, 1, 8, 9 };
        Array.Sort(myNumbers);
        foreach (int number in myNumbers)
        {
            Console.WriteLine(number);
        }

        //Multidimensional Attay
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        Console.WriteLine(numbers[0, 2]);

        //Function with parameters
        add(30, 50);
        add(30);

        //Method Overloading
        add("Shravani", "Patil");
    }


    //Function
    public static void add(int number1, int number2 = 20)
    {
        Console.WriteLine("Addition = " + number1 + number2);
    }

    public static void add(String st1,String st2)
    {
        Console.WriteLine("Concatination of Strings = " + st1 + st2);   
    }
}