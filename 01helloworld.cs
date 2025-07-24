/*
 * what is .NET?
 * NET is a versatile, free, and open-source cross-platform developer platform/framework 
 * used for building a wide range of applications, including web, 
 * mobile, desktop, and cloud services.
 * 
 * dotnet requires:
 * visualstudio and +.Net desktop development, + Asp.net and Web devlopment
 * **/

using System; //we are using System namespace classes.

namespace Hello { //namespace Hello
    /* namespace: is a container that groups related 
     * classes, interfaces, structs, enums, and other namespaces.
     */
    class Program { //class Program
        //class is container for data and methods.
        static void Main(string[] args) {
            //Main() function used to start the App execution 
            int a = 34; //variable
            Console.WriteLine("Hello world.");
            Console.WriteLine("prints output in a new line.");
            Console.Write("prints the output in same line.");
            Console.Write(" value of variable a:" + a);
            Console.ReadLine();// to pause the output console
        }
    }
}

//comments:
//single line comment.
/**
 * multi
 * line 
 * comment.
 */
