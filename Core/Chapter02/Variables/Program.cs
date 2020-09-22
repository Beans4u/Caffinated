using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
           // object height = 1.88;
            //object name = "Amir";

           // System.Console.WriteLine($"{name} is {height} meters tall.");

            //int length1 = name.Length; //will give compile error
           // int length2 = ((string)name).Length; //tell compiler it is a string
           // System.Console.WriteLine($"{name} has {length2} characters");

            //storing string in a dynamic object
            //dynamic anotherName = "Ahmed";

            // this compiles but would throw an exception at run-time
            // if you later store a data type that does not have a
            // property named Length
            //int length = anotherName.Length;
            // System.Console.WriteLine($"{anotherName} has {length} characters");
        
        System.Console.WriteLine($"default (int) = {default(int)}");
        System.Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            
        
        
        }
    }
}
