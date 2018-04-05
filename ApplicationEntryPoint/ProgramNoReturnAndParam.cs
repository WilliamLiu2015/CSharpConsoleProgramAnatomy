using System;

namespace ApplicationEntryPoint
{
    class ProgramNoReturnAndParam
    {
        /*
         * Variation on the Main( ) Method
         */
        static void Main()  // No parameters but still able to get any command-line arguments from System.Environment
        {
            Console.WriteLine("***** The C# Application Entry Point *****");
            Console.WriteLine("No return type, No parameters");
            Console.WriteLine();

            // The first element contains the name of the application itself, while the remaining elements in the array contain the individual command-line arguments. 
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            Console.ReadLine();
        }
    }
}
