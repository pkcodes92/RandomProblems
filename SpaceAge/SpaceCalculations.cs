// <copyright file="SpaceCalculations.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace SpaceAge
{
    /// <summary>
    /// This class is a partial class for the space calculations.
    /// </summary>
    public partial class SpaceCalculations
    {
        private readonly int Seconds;

        /// <summary>
        /// This initializes a type of <see cref="SpaceCalculations"/>.
        /// </summary>
        /// <param name="seconds"></param>
        public SpaceCalculations(int seconds)
        {
            Seconds = seconds;
        }

        /// <summary>
        /// This will calculate the age on Earth.
        /// </summary>
        /// <returns>A person's age on Earth.</returns>
        public double OnEarth()
        {
            return Seconds / Constants.SECONDS_IN_EARTH_YEAR; 
        }

        /// <summary>
        /// Calculates the age on Mercury.
        /// </summary>
        /// <returns>A double value that will return the correct value.</returns>
        public double OnMercury()
        {
            return ApplyPeriod(Constants.MERCURY_PERIOD); 
        }

        /// <summary>
        /// This method calculates a person's age on Venus.
        /// </summary>
        /// <returns>A person's age on Venus.</returns>
        public double OnVenus()
        {
            return ApplyPeriod(Constants.VENUS_PERIOD); 
        }

        /// <summary>
        /// This method calculates a person's age on Mars.
        /// </summary>
        /// <returns>A person's age on Mars.</returns>
        public double OnMars()
        {
            return ApplyPeriod(Constants.MARS_PERIOD); 
        }

        /// <summary>
        /// This method calculates a person's age on Jupiter.
        /// </summary>
        /// <returns>A person's age on Jupiter.</returns>
        public double OnJupiter()
        {
            return ApplyPeriod(Constants.JUPITER_PERIOD); 
        }

        /// <summary>
        /// This method calculates a person's age on Saturn.
        /// </summary>
        /// <returns>A person's age on Saturn.</returns>
        public double OnSaturn()
        {
            return ApplyPeriod(Constants.SATURN_PERIOD);
        }

        /// <summary>
        /// This method calculates a person's age on Uranus.
        /// </summary>
        /// <returns>A person's age on Uranus.</returns>
        public double OnUranus()
        {
            return ApplyPeriod(Constants.URANUS_PERIOD);
        }

        /// <summary>
        /// This method calculates a person's age on Neptune.
        /// </summary>
        /// <returns>A person's age on Neptune.</returns>
        public double OnNeptune()
        {
            return ApplyPeriod(Constants.NEPTUNE_PERIOD);
        }

        private double ApplyPeriod(double period)
        {
            return OnEarth() / period;
        }
    }
}