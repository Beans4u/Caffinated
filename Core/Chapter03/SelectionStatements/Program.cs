using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // object o = 3;
            // int j = 4;
            
            // if (o is int i)
            // {
            //     WriteLine($"{i} x {j} = {i * j}");
            // }
            // else
            // {
            //     WriteLine("o is not an int so it cannot multiply!");
            // }

            // A_label:
            //     var num = (new Random()).Next(1,7);

            //     WriteLine($"My random number is {num}");

            //     switch (num)
            //     {
            //         case 1:
            //             WriteLine("one");
            //             break;
            //         case 2:
            //             WriteLine("two");
            //             break;
            //         case 3:
                        
            //         case 4:
            //             WriteLine("three or four");
            //             break;
            //         case 5: //go to sleep for half a second
            //             System.Threading.Thread.Sleep(500);
            //             goto A_label;
            //             break;
            //         default:
            //             WriteLine("default");
            //             break;
            
                // string path = @"D:\devproject\cBook\Core\Chapter03";

                // Stream s = File.Open(
                //     Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

                // string message = string.Empty;
                
                // message = s switch
                // {
                //     FileStream writeableFile when s.CanWrite
                //         => "The stream is a file that I can write to",
                //     FileStream readOnlyFile
                //         => "The stream is read only",
                //     MemoryStream ms
                //         => "The stream is a memory addrress",
                //     null
                //         => "The stream is null",
                //     _
                //         => "The stream is some other type.",
                // };
                
                // WriteLine(message);

                // switch (s) 
                // {
                //     case FileStream writeableFile when s.CanWrite:
                //         message = "The stream is a file that I can write to.";
                //         break;
                //     case FileStream readOnlyFile:
                //         message = "The stream is a read-only file.";
                //         break;
                //     case MemoryStream ms:
                //         message = "The stream is a memory address.";
                //         break;
                //     default: //always eval'd last despite its current posn
                //         message = "The stream is some other type.";
                //         break;
                //     case null:
                //         message = "The stream is null.";
                //         break;
                // }

                // WriteLine(message);
                
            
            
            
        }
    }
}
