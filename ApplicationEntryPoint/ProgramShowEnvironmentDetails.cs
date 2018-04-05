using System;

namespace SystemEnvironment
{
    class ProgramShowEnvironmentDetails
    {
        static void Main()
        {
            Console.WriteLine("***** Some Useful Members of the System.Environment Class *****");
            Console.WriteLine("Print out the drives on this machine and other interesting details");
            Console.WriteLine();

            ShowEnvironmentDetails();

            Console.ReadLine();
        }

        static void ShowEnvironmentDetails()
        {
            Console.WriteLine("The host name: {0}",
                Environment.MachineName);

            Console.WriteLine("OS: {0}", 
                Environment.OSVersion);

            if (Environment.Is64BitProcess)
                Console.WriteLine("The host machine is running a 64-bit OS");

            Console.WriteLine("Number of processors: {0}",
                Environment.ProcessorCount);            

            Console.WriteLine(".NET platform version: {0}",
                Environment.Version);

            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("The system directory: {0}",
                Environment.SystemDirectory);

            Console.WriteLine("The user Name: {0}",
                Environment.UserName);

            Console.WriteLine("The domain Name: {0}",
                Environment.UserDomainName);

            Console.ReadLine();
        }

    }
}
