// See https://aka.ms/new-console-template for more information
using System;

class Program2{
    static void Main(){
        // Boolean 
        // bool b = true;
        // Integral Type integer
        // int i = 0;
        // Console.WriteLine($"Min = {int.MinValue}");
        // Console.WriteLine($"Max = {int.MaxValue}");
        // String Types
        // string Name = "\"Neo\"";
        string count = "\"one\"\n\"two\"\n\"three\"";
        Console.WriteLine(count);
        // Verbatim Literal String
        string ver = @"the\\esc\\sequences\\dont\\work";
        string ver2 = @"This is how to write with out "" issues";
        Console.WriteLine(ver);
        Console.WriteLine(ver2);
    }
}

