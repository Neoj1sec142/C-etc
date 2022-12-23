// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        ParamsMethod(12,22,63,42,55,64,71,84,10);
        //^^ You can also use parameter arrays^^
        // int[] Numbers = new int[3];
        // Numbers[0] = 101;
        // Numbers[1] = 102;
        // Numbers[2] = 103;
        // ParamsMethod(Numbers);
    }
    // If you are using the params array you need to pass it last as
    // a parameter if you have more than one kind of param to pass in
    public static void ParamsMethod(params int[] Numbers){
        Console.WriteLine($"There are {Numbers.Length} elements");
        int Count = 1;
        foreach(int i in Numbers){
            Console.WriteLine($"Number {Count} is {i}");
            Count++;
        }
    }

    // Passing out Params
    // static void Main(){
    //     int Total = 0;
    //     int Product = 0;
    //     Calculate(10, 20, out Total, out Product);
    //     Console.WriteLine($"Sum = {Total}");
    //     Console.WriteLine($"Product = {Product}");
    // }
    // public static void Calculate(int FN, int SN, out int Sum, out int Product){
    //     Sum = FN + SN;
    //     Product = FN * SN;
    // }
    // Passing With Reference
    // static void Main(){
    //     int i = 0;
    //     SimpleMethod(ref i);
    //     Console.WriteLine(i);
    // }
    // public static void SimpleMethod(ref int j){
    //     j = 101;
    // }

    // ^^^^^^^^^
    // Below is lesson 16 Methods
    // static void Main(){    
    //     Program.EvenNumbers(30);
    //     Program p = new Program();
    //     int Sum = p.Add(10, 20);
    //     Console.WriteLine(Sum);
    // }
    // public int Add(int FN, int SN){
    //     return FN + SN;
    // }
    // public static void EvenNumbers(int Target){
    //     int Start = 0;
    //     while(Start <= Target){
    //         Console.WriteLine(Start);
    //         Start += 2;
    //     }
    // }
    // ^^^^^^
    // Without the static key word you need to create an
    // instance of the class to access a method
    // static void Main(){
        // Program p = new Program();
        // p.EvenNumbers();
    // }
    // public void EvenNumbers(){
    //     int Start = 0;
    //     while(Start <= 20){
    //         Console.WriteLine(Start);
    //         Start += 2;
    //     }
    // }
};
