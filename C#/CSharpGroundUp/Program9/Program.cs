// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        
        // Program.EvenNumbers(30);
        Program p = new Program();
        int Sum = p.Add(10, 20);
        Console.WriteLine(Sum);
    }
    public int Add(int FN, int SN){
        return FN + SN;
    }
    // public static void EvenNumbers(int Target){
    //     int Start = 0;
    //     while(Start <= Target){
    //         Console.WriteLine(Start);
    //         Start += 2;
    //     }
    // }
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
