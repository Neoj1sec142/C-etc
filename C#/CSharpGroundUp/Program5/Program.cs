// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        // You have to declare how many items are in the array
        // The array is not resizeable like in js
        int[] intArray = new int[3];
        intArray[0] = 0;
        intArray[1] = 1;
        intArray[2] = 2;
        Console.WriteLine(intArray[1]);
    }
}
