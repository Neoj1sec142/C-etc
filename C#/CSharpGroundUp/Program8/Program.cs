// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        // int[] Numbers = new int[3];
        // Numbers[0] = 101;
        // Numbers[1] = 102;
        // Numbers[2] = 103;
        
        // foreach(int k in Numbers){
        //     Console.WriteLine(k);
        // }

        // Done with for loop
        // for(int j=0; j < Numbers.Length; j++){
        //     Console.WriteLine(Numbers[j]);
        // }

        // Break Statement in For loop
        // for(int i=1; i <= 20; i++){
        //     Console.WriteLine(i);
        //     if(i == 10) break;
        // }

        // Continue Keyword
        for(int i = 0; i<=20; i++){
            if(i %2 == 1) continue;
            Console.WriteLine(i);
            if(i == 10) break;
        }
    }
}
