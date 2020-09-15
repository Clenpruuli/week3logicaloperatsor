using System;

namespace TestFeedBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What mark did you get?");
            string mark = Console.ReadLine().ToLower();

            switch (mark)
            { 
            case "a":
                Console.WriteLine("Excellent!");
                break;
            case "b":
                Console.WriteLine("Very good!");
                break;
            case "c":
                Console.WriteLine("Passed");
                break;
            case "d":
                Console.WriteLine("Failed");
                 break;
            default:
                Console.WriteLine("Wasted!");
                break;
            }

        }
    }
}
