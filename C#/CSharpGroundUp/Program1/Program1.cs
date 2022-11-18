using System;
class Program1
{
    static void Main(){
        Console.WriteLine("Please enter your first name: ");
        string? FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        string? LastName = Console.ReadLine();
        
        // Concatenate sting Method
        // Console.WriteLine("Hello " + FirstName + " " + LastName);
        
        // Placeholder Method
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        
        // String Literal Method
        // Console.WriteLine($"Hello {FirstName} {LastName}");
    }
}

