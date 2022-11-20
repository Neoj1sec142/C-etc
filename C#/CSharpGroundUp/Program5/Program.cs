// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        // You have to declare how many items are in the array
        // The array is not resizeable like in js
        // int[] intArray = new int[3];
        // intArray[0] = 0;
        // intArray[1] = 1;
        // intArray[2] = 2;
        // Console.WriteLine(intArray[1]);

        // conditional if statements
        // Console.WriteLine("Enter a Number: ");
        // int res = int.Parse(Console.ReadLine());
        // if(res == 1){
        //     Console.WriteLine("1");
        // }else if(res == 2){
        //     Console.WriteLine("2");
        // }else{
        //     Console.WriteLine("IDK");
        // }

        // Conditional Switch Statements
        Console.WriteLine("please enter a number");
        int num = int.Parse(Console.ReadLine());
        // if(num == 10){
        //     Console.WriteLine("Your number is 10");
        // }else if (...)
        switch(num){
            case 10:
            case 20:
            case 30:
                Console.WriteLine($"Your number is {num}");
                break;
            default:
                Console.WriteLine("Your number is not 10, 20, or 30");
                break;
        }
    }
}
