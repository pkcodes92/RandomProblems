// <copyright file="Meetup.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace MeetupFinder
{
    using System;

    /// <summary>
    /// This is the schedule enumeration.
    /// </summary>
    public enum Schedule
    {
        /// <summary>
        /// The value for example the thirteenth of the month.
        /// </summary>
        Teenth,

        /// <summary>
        /// This represents the first day of the month.
        /// </summary>
        First,

        /// <summary>
        /// This represents the second day of the month.
        /// </summary>
        Second,

        /// <summary>
        /// This represents the third day of the month.
        /// </summary>
        Third,

        /// <summary>
        /// This represents the fourth day of the month.
        /// </summary>
        Fourth,

        /// <summary>
        /// This represents the last day of the month.
        /// </summary>
        Last
    }

    /// <summary>
    /// This is the meetup class.
    /// </summary>
    public class Meetup
    {
        const double WEEK = 7;
        const double TEENTH = 12;
        
        /// <summary>
        /// The integer for the month to initialize.
        /// </summary>
        protected int month = 0;

        /// <summary>
        /// The integer value of the year to initialize.
        /// </summary>
        protected int year = 0;

        /// <summary>
        /// Initializes an instance of the <see cref="Meetup"/> class.
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        public Meetup(int month, int year)
        {
            this.month = month;
            this.year = year;
        }

        /// <summary>
        /// This returns the actually day.
        /// </summary>
        /// <param name="dayOfWeek">The day of the week.</param>
        /// <param name="schedule">The number of the day.</param>
        /// <returns></returns>
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