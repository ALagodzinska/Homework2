using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region mainInfo
            string Greeting = "Hello everyone! " +
                "Here you'll see main information about myself.\n";

            string Name = "Anastasija";

            string Surname = "Lagodzinska";

            byte Age = 23;

            char Gender = 'F';

            //Line1
            Console.WriteLine(Greeting);

            //Line2
            Console.WriteLine($"My name: {Name} {Surname}");

            //Line3
            Console.WriteLine($"My age: {Age}");

            //Line4
            Console.WriteLine($"My gender: {Gender}");

            Console.WriteLine(Environment.NewLine);
            #endregion

            #region AdditionalInfo

            string moreIntro = @"Here I provided some additional facts.
You can get to know me better." + Environment.NewLine;

            decimal Height = 1.77m;
            string fullHeight = Height.ToString() + " meters";

            string Number1 = "1990";
            int Number2 = 8;
            int intNumber1 = int.Parse(Number1);
            int result = Number2 + intNumber1;

            int hoursComputer = 3;
            decimal hoursPhone = 0.9m;
            int decHoursPhone = (int)hoursPhone;
            int result2 = hoursComputer + decHoursPhone;

            //Line5
            Console.WriteLine(moreIntro);

            //Line6
            Console.WriteLine($"My height: {fullHeight}");

            //Line7
            Console.WriteLine($"The year I was born: {result}");

            //Line8
            Console.WriteLine($"How much time i spend in the internet: {result2} hours a day.");

            #endregion

            //End
            Console.ReadLine();

        }
    }
}
