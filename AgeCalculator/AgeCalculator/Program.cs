using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            var userInput = Console.ReadLine();

            
            DateTime userBirthday = DateTime.Parse(userInput);
            DateTime now = DateTime.Now;

            TimeSpan subtract = now.Subtract(userBirthday);

            //variables.
            var age = subtract.TotalDays / 365;
            var months = subtract.TotalDays / 30.4368;
            var weeks = subtract.TotalDays / 7;
            var days = subtract.TotalDays;
            var hours = subtract.TotalHours;
            var minutes = subtract.TotalMinutes;
            var seconds = subtract.TotalSeconds;
            var milliseconds = subtract.TotalMilliseconds;


            //print the age.
            Console.WriteLine("I am " + Math.Floor(age) + " years old.");
            Console.WriteLine("I am " + Math.Floor(months) + " years old.");
            Console.WriteLine("I am " + Math.Floor(weeks) + " years old.");
            Console.WriteLine("I am " + Math.Floor(days) + " years old.");
            Console.WriteLine("I am " + Math.Floor(hours) + " hours old");
            Console.WriteLine("I am " + Math.Floor(minutes) + " minutes old");
            Console.WriteLine("I am " + Math.Floor(seconds) + " seconds old");
            Console.WriteLine("I am " + Math.Floor(milliseconds) + " milliseconds old");



            Console.ReadLine();

        }
    }
}
