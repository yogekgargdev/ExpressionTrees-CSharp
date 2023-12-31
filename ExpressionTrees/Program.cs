﻿
using ExpressionTrees;

public class Program
{

    public static void Main(String[] args)
    {
        // Delegates are of two types 1) Func ==> returns something 2) Action ==> doesn't return anything
        // In Func the last parameter is the return type, rest u can add as many input parameters as you want

        Func<int, int, int> sum = (x, y) => x + y;
        var SumAdditionValue = sum(2, 3);
        Console.WriteLine("SumAdditionValue: " + SumAdditionValue);

        // Example with Passing a class as a Parameter in the Func, but we need to create an object and pass to the calling function

        Func<MyClass, string> func = c => c.MyMethod(3,"Test String");
        MyClass myClass = new MyClass();
        Console.WriteLine("func(myClass): "+func(myClass));

        Func<MyClass, int> func1 = c => c.MyProperty;
        Console.WriteLine("func1(myClass): " + func1(myClass));

        // Action Example
        Action<int, int> action = (x, y) => Console.Write(x + y);
        Console.WriteLine("Action Example: ");
        action(3, 4);

        // Expression is just a data structure representing code, it can't be executed whereas Func and Actions can be invoked.
        // Expression and Func look almost the same, but they are different in terms of they are working

    }


}

