using System;

namespace ApplicationEntryPoint
{
    /*
     * Every C# executable program must have a type defining a Main() method, which
     * serves as the program's entry point.
     * 
     * The class defining Main() is termed the application object and 
     * an executable application could have more than one application object.
     * 
     * An application object is named as Program by default but 
     * the name can be renamed.
     */
    class Program
    {
        /*
         * Every executable application (console program, Windows desktop program, or 
         * Windows service) must contain an application object. The Main() method is 
         * used to signify the entry point of the application.
         * 
         * The Main() method by default has a void return value and an array of input parameters (string type).
         */
        static void Main(string[] args) // The Main() method is invoked without instantiate application object.
        {
            Console.Title = "C# Application Entry Point";
            Console.WriteLine("A void return value, An array of string types as the single input parameter");
            Console.WriteLine();

            // Process any incoming args using standard for loop.
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg: {0}", args[i]);

            // Process any incoming args using foreach.
            foreach (string arg in args)
                Console.WriteLine("Arg: {0}", arg);
            
            Console.ReadLine(); 
        }
    }
}
