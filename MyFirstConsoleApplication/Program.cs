using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ryan";
            char firstLetter = 'R';

            //Number types
            short littleNumber = Int16.MaxValue;

            int number = Int32.MaxValue;

            long bigNumber = Int64.MaxValue;

            Console.WriteLine(littleNumber);
            Console.WriteLine(number);
            Console.WriteLine(bigNumber);

            var today = DateTime.Today;

            //Instantiation - Creating an instance of the DateTime using "new"
            var bestYear = new DateTime(2020, 1, 1);

            //anonymous type, new object
            var person = new {Name = "Ryan"};

            //everything either is or can be an object
            object weirdStuff = 1234;
            weirdStuff = "More craziness";

            Console.WriteLine(weirdStuff);

        }
    }
}
