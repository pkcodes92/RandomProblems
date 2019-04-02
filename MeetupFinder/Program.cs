namespace MeetupFinder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var dateTest = new Meetup(12, 2012);
            var expected = new DateTime(2012, 12, 7);

            Console.WriteLine(expected == dateTest.Day(DayOfWeek.Friday, Schedule.First) ? "Yahtzee" : "Not quite");
            Console.WriteLine("The program execution has completed - you can press any key to exit");

            Console.ReadKey();
        }
    }
}