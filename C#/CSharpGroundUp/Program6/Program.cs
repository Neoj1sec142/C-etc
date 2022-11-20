// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        int totalCost = 0;
        Start:
        Console.WriteLine("Please select your coffee size.");
        Console.WriteLine("1. Small, 2. Medium, 3. Large");
        int userChoice = int.Parse(Console.ReadLine());
        switch(userChoice){
            case 1:
                totalCost += 1;
                break;
            case 2:
                totalCost += 2;
                break;
            case 3:
                totalCost += 3;
                break;
            default: 
                Console.WriteLine($"Your choice {userChoice} is invalid. PLease try again.");
                goto Start;
        }
        Decide:
        Console.WriteLine("Is that all for your order?");
        string userCont = Console.ReadLine();
        switch(userCont.ToUpper()){
            case "Y":
            case "YES":
                break;
            case "N":
            case "NO":
                goto Start;
            default:
                Console.WriteLine($"Your choice {userCont} was invalid. Please try again.");
                goto Decide;
        }

        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine($"Total cost: ${totalCost}.00");
    }
}

