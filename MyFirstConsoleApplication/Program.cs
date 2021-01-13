using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           //Inputting data:
            Console.WriteLine("What is your first name?");
            var input = Console.ReadLine();


            //strings
            string name = "Ryan";
            char firstLetter = 'R';

            //JS Example: let myInterpolatedString = `this stuff ${firstLetter}`;
            var myInterpolatedString = $"My name is {name} and the " +
                $"first letter of my name is {firstLetter}";

            var stringLiteral = @"This is a paragraph.
                                  It is across multiple lines.
                                  Returns will be honored in the output.";

            Console.WriteLine(myInterpolatedString);
            Console.WriteLine(stringLiteral);

            //Number types
            short littleNumber = Int16.MaxValue;

            int number = Int32.MaxValue;

            long bigNumber = Int64.MaxValue;

            Console.WriteLine(littleNumber);
            Console.WriteLine(number);
            Console.WriteLine(bigNumber);

            //decimals can be represented by (f)loat(32bit) (d)ouble(64bit) or deci(m)al(128bit)
            var adding = 1 + 1.1f;

            //need to define number type using d or m in order to receive anything more than a whole number
            var division = 3 / 2d;

            var today = DateTime.Today;

            //Instantiation - Creating an instance of the DateTime using "new"
            var bestYear = new DateTime(2020, 1, 1);

            //anonymous type, new object
            var person = new {Name = "Ryan"};

            //everything either is or can be an object
            object weirdStuff = 1234;
            weirdStuff = "More craziness";

            Console.WriteLine(weirdStuff);

            var names = new string[5];

            var secondName = names[1];
            names[1] = "Jimmy";

            var colors = new string[] { "white", "blue", "black", "yellow", "teal", "magenta" };

            if (input == "Ryan")
            {
                Console.WriteLine("duh");
            }
            else if (input == "blerg")
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Not Ryan");
            }

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"currently for looping on number {colors[i]}");
            }

            var counter = 1;

            while (true)
            {
                Console.WriteLine($"While loop iteration {counter}.");

                if (counter <= 5)
                {
                    counter++;
                    continue;
                }
                break;
            }

            foreach (var color in colors)
            {
                Console.WriteLine($"Foreach looping on color {color}");
            }
        }


    }
}
