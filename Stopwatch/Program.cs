using System;

namespace Stopwatch
{
    class Program
    {
        static void Main (string[] args) {
            var stopwatch = new Stopwatch ();
            var isRunning = true;
            Console.WriteLine ("1 - Start");
            Console.WriteLine ("2 - Stop");
            Console.WriteLine ("3 - Exit");

            do {
                Console.Write ("Please choose the number: ");

                int menu;
                var isValid = int.TryParse (Console.ReadLine (), out menu);
                if (!isValid) {
                    System.Console.WriteLine ("Please enter the proper number");
                    continue;
                }

                try {
                    switch (menu) {
                        case 1:
                            stopwatch.Start ();
                            break;
                        case 2:
                            stopwatch.Stop ();
                            break;
                        case 3:
                            System.Console.WriteLine ("Exit the program.");
                            isRunning = !isRunning;
                            break;
                        default:
                            System.Console.WriteLine ("Invalid menu. Please try again.");
                            break;
                    }
                } catch (Exception e) {
                    System.Console.WriteLine(e.Message);
                }

            } while (isRunning);
        }
    }
}
