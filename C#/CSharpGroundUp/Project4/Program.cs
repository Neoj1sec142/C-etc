// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main(){
        /* IMPLICIT CONVERSION
        implicit conversion takes place when there is no 
        possibility of loss of data, like when going from
        whole number to decimal. The whole numbers decimal 
        is defaulted = .0 so nothing is possible to loose 
        like if we were going the oppisite direction
        int i = 100;
        float f = i;
        Console.WriteLine(f);
        */ 

        // Type Cast Operator (Does NOT Round)
        // Also Throws No Exception
        float f = 123.75F;
        int i = (int)f;
        Console.WriteLine(i);

        // Using the Convert class (Does Round Up)
        // Also Throws Exception upon invalid conversion
        // float f = 123.75F;
        // int i = Convert.ToInt32(f);
        // Console.WriteLine(i);

        // Parse
        string strNum = "100";
        int i = int.Parse(strNum);
        Console.WriteLine(i);
    }
}
