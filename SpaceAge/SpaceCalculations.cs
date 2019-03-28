namespace SpaceAge
{
    public class SpaceCalculations
    {
        public struct Constants
        {
            /// <summary>
            /// The number of seconds in a year on Earth
            /// </summary>
            public const double SECONDS_IN_EARTH_YEAR = 31557600.0;

            /// <summary>
            /// The orbital period of Mercury as measured in Earth years
            /// </summary>
            public const double MERCURY_PERIOD = 0.2408467;

            /// <summary>
            /// The orbital period of Venus as measured in Earth years
            /// </summary>
            public const double VENUS_PERIOD = 0.61519726;

            /// <summary>
            /// The orbital period of Mars as measured in Earth years
            /// </summary>
            public const double MARS_PERIOD = 1.8808158;

            /// <summary>
            /// The orbital period of Jupiter as measured in Earth years
            /// </summary>
            public const double JUPITER_PERIOD = 11.862615;

            /// <summary>
            /// The orbital period of Saturn as measured in Earth years
            /// </summary>
            public const double SATURN_PERIOD = 29.447498;

            /// <summary>
            /// The orbital period of Uranus as measured in Earth years
            /// </summary>
            public const double URANUS_PERIOD = 84.016846;

            /// <summary>
            /// The orbital period of Neptune as measured in Earth years
            /// </summary>
            public const double NEPTUNE_PERIOD = 164.79132; 
        }

        private readonly int Seconds;
        public SpaceCalculations(int seconds)
        {
            Seconds = seconds;
        }

        private double ApplyPeriod(double period)
        {
            return OnEarth() / period;
        }

        public double OnEarth()
        {
            return Seconds / Constants.SECONDS_IN_EARTH_YEAR; 
        }

        /// <summary>
        /// Calculates the age on Mercury
        /// </summary>
        /// <returns>A double value that will return the correct value</returns>
        public double OnMercury()
        {
            return ApplyPeriod(Constants.MERCURY_PERIOD); 
        }

        public double OnVenus()
        {
            return ApplyPeriod(Constants.VENUS_PERIOD); 
        }

        public double OnMars()
        {
            return ApplyPeriod(Constants.MARS_PERIOD); 
        }

        public double OnJupiter()
        {
            return ApplyPeriod(Constants.JUPITER_PERIOD); 
        }

        public double OnSaturn()
        {
            return ApplyPeriod(Constants.SATURN_PERIOD);
        }

        public double OnUranus()
        {
            return ApplyPeriod(Constants.URANUS_PERIOD);
        }

        public double OnNeptune()
        {
            return ApplyPeriod(Constants.NEPTUNE_PERIOD);
        }
    }
}