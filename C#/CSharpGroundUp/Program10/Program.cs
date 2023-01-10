// See https://aka.ms/new-console-template for more information
using System;
using ProjectA.TeamA;
using System.Collections;
using System.Configuration;
// using ATA = ProjectA.TeamA;
// using ATB = ProjectA.TeamB;
class Program{
    static void Main(){
        ClassA.Print();
        
    }
}

namespace ProjectA{
    namespace TeamA{
        class ClassA{
            public static void Print(){
                Console.WriteLine("TeamA Print Method");
            }
        }
    }
}

namespace ProjectA{
    namespace TeamB{
        class ClassA{
            public static void Print(){
                Console.WriteLine("TeamB Print Method");
            }
        }
    }
}