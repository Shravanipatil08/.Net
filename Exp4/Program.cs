using Exp4;
using System;

class Program
{
    public delegate void OrderProcess(); //multi cast
    public delegate void updateRecords(); //single cast

    public static void SendEmail()
    {
        Console.WriteLine("Order Placed for User.");
    }

    public static void GenerateBill()
    {
        Console.WriteLine("Bill and Invoice Generated !");
    }

    public static void updateInventory()
    {
        Console.WriteLine("Inventory Updated.");
    }

    //single method
    public static void updateHistory()
    {
        Console.WriteLine("Updating Records...");
    }
    public static void Main()
    {
        ////Multi casting
        //OrderProcess process = SendEmail;
        //process += GenerateBill;
        //process += updateInventory;

        //Console.WriteLine("Order Placed Successfully!\n");
        //process();

        ////single casting
        //updateRecords update = updateHistory;
        //update();

        //2.Lambda with delegates
        //LambdaDelegates.lambdaDelegate();

        //3.Sorting with lambda
        SortingLambda.sortList();
    }
}