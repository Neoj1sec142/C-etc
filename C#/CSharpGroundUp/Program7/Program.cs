// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        // WHILE LOOPS
        // Console.WriteLine("Please enter your target number: ");
        // int userTarget = int.Parse(Console.ReadLine());
        // int Start = 0;
        // while(Start <= userTarget){
        //     Console.Write(Start+" ");
        //     Start += 2;
        // }

        // Do While loop
        string userChoice = string.Empty;
        do{
            Console.WriteLine("Please enter your target number: ");
            int userTarget = int.Parse(Console.ReadLine());
            int Start = 0;
            while(Start <= userTarget){
                Console.Write(Start+" ");
                Start += 2;
            }
            do{
                Console.WriteLine("Do you want to continue?");
                userChoice = Console.ReadLine().ToUpper();
                if(userChoice != "YES" && userChoice != "NO"){
                    Console.WriteLine("Invalid Choice: either Yes or No");
                }
            }while(userChoice != "YES" && userChoice != "NO");
        }while(userChoice == "YES");
        
    }
}
