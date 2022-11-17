// See https://aka.ms/new-console-template for more information
using System;

class Program3{
    static void Main(){
        // = Assignment Opertator
        // int i = 10;

        // Arithmetic Operators
        // int i = 10;
        // int j = 2;
        // int add = i + j;
        // int sub = i - j;
        // int mul = i * j;
        // int div = i / j;
        // int rem = i % j;

        // Console.WriteLine($"add:{add}, sub:{sub}\n");
        // Console.WriteLine($"mul:{mul}, div:{div}\n");
        // Console.WriteLine($"rem:{rem}");
        // Conditionals
        // int i = 3;
        // int j = 4;
        // if (i == 2 && j == 4){
        //     Console.WriteLine("Yoooo");
        // }else{
        //     Console.WriteLine("Broooo");
        // }
        
        // if (i == 3 || j == 7){
        //     Console.WriteLine("Stonch");
        // }else{
        //     Console.WriteLine("McStonchy");
        // }
        // Console.WriteLine(i == 3 ? "Terenary Stonch" : "Blahhhhh");

        // Null and Nullable types
        // string Name = null; // Is nullable
        // int i = null; // Does Not Work
        // int? i = null; // Makes the int nullable
        // Console.WriteLine(i);
        // Console.WriteLine("Are you a major?");
        // bool? AreYouMajor;
        // string ans = Console.ReadLine();
        // if(ans == "Y"){
        //     AreYouMajor = true;
        // }else if(ans == "N"){
        //     AreYouMajor = false;
        // }else{
        //     AreYouMajor = null;
        // }
        // if(AreYouMajor == true){
        //     Console.WriteLine("true");
        // }else if (AreYouMajor == false){
        //     Console.WriteLine("false");
        // }else if(AreYouMajor == null){
        //     Console.WriteLine("Null");
        // }

        // Null Colessing 
        int? TicketsOnSale = null;
        int AvailableTickets = TicketsOnSale ?? 0;
        // Instead of 
        // if(TicketsOnSale == null){
        //     AvailableTickets = 0;
        // }else{
        //     //...
        // }
    }
}