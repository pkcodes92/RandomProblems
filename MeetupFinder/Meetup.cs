namespace MeetupFinder
{
    using System;

    public enum Schedule
    {
        Teenth, 
        First, 
        Second, 
        Third,
        Fourth,
        Last
    }

    public class Meetup
    {
        const double WEEK = 7;
        const double TEENTH = 12;
        protected int month = 0;
        protected int year = 0;

        public Meetup(int month, int year)
        {
            this.month = month;
            this.year = year;
        }

        public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
        {
            DateTime date = new DateTime(year, month, 1);
            if (schedule == Schedule.Teenth)
            {
                date = date.AddDays(TEENTH);
            }
            else if (schedule == Schedule.Second || schedule == Schedule.Third || schedule == Schedule.Fourth)
            {
                date = date.AddDays(WEEK * ((int)Enum.Parse(typeof(Schedule), schedule.ToString()) - 1));
            }
            else if (schedule == Schedule.Last)
            {
                date = date.AddDays(DateTime.DaysInMonth(date.Year, date.Month) - 1);
                date = date.AddDays((WEEK - 1) * -1);
            }

            if ((double)date.DayOfWeek > (double)dayOfWeek)
            {
                date = date.AddDays((WEEK + (double)dayOfWeek) - (double)date.DayOfWeek);
            }
            else if ((double)date.DayOfWeek < (double)dayOfWeek)
            {
                date = date.AddDays((double)dayOfWeek - (double)date.DayOfWeek);
            }

            return date;
        }
    }
}