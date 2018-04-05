using System;

namespace ApplicationEntryPoint
{
    class ProgramWithReturnNoParam
    {
        /*
         * Variation on the Main( ) Method
         */
        static int Main()
        {
            Console.WriteLine("***** The C# Application Entry Point *****");
            Console.WriteLine("Int return type, No parameters");
            Console.WriteLine();

            Console.ReadLine();

            return 0; // By convention, returning 0 indicates the program has terminated successfully, while another value (such as -1) represents an error condition.
        }
    }
}
