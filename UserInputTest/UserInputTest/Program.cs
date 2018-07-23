// Just a Starter program to calculate the sum of seconds from days, hours, minutes and seconds....

using System;

namespace TestAppForUserInut
{

    class Program {


        static void Main() {


            Console.WriteLine("\nHello! Whats your name?");

            var userName = Console.ReadLine();

            Console.WriteLine($"\nHello {userName}. ");
            System.Threading.Thread.Sleep(2500);



            Console.WriteLine("\nInput days:");
            double days = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput hours:");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput minutes:");
            double minutes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput seconds:");
            double seconds = Convert.ToDouble(Console.ReadLine());


            double time = (days * 3600 * 24) + hours * 3600 + minutes * 60 + seconds;
            ulong finallTime = Convert.ToUInt64(time);


            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"\nThe seconds are {finallTime}");

            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("\nDo you want to do another conversion? [Y/N]");
            var answer = Console.ReadLine();


            answer = answer.ToLower();



            if (answer == "Y") {

                Console.WriteLine("\nOk... Starting again!");
                System.Threading.Thread.Sleep(3000);
            }

            else if (answer == "N") {

                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("\nOk. Thank's for using my converter!");
            }

            else {
                System.Threading.Thread.Sleep(1650);
                Console.WriteLine("\nNo answer given... Asking again.");
            }
            


        }
    }
}



/*      
*           TODO:  Make a function with all the "algorithm" of converting time to Secs.  to help me, when the user inputs "Y"  to start again.      
*/
