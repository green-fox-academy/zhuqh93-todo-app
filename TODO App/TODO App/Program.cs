using System;

namespace TODO_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_Usage_Information();
        }

        static void Print_Usage_Information()
        {
            Console.WriteLine("Command Line Todo application \n" +
                              "============================= \n" +
                              "\n" +
                              "Command line arguments: \n" +
                              " -l   Lists all the tasks \n" +
                              " -a   Adds a new task \n" +
                              " -r   Removes an task \n" +
                              " -c   Completes an task \n" +
                              "\n");
        }
    }
}
