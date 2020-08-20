// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace FactoryDesignPattern
{
    using System;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific, command line arguments.</param>
        public static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.WriteLine("Enter the card type you would like to use: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine($"Card Type: {creditCard.CardType}\nCredit Limit: {creditCard.CreditLimit}\nAnnual Charge: {creditCard.AnnualCharge}");
            Console.ReadKey();
        }
    }
}