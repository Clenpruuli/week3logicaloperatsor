using System;

namespace Week3LogicalOperatorsOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine().ToLower();

            if (month == "december" || month == "january" || month == "february")
            {
                Console.WriteLine("You were born in winter");
            }
            else if (month == "march" || month == "april" || month == "may")
            {
                Console.WriteLine("You were born in spring");
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                Console.WriteLine("You were born in summer");
            }
            else if (month == "september" || month == "october" || month == "november")
            {
                Console.WriteLine("You were born in autumm");
            }
            else
                Console.WriteLine("This is not a month");




        }
    }
}