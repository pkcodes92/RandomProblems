// <copyright file="CreditCard.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace FactoryDesignPattern
{
    /// <summary>
    /// This class represents the 'Product' class which is to be generated.
    /// This is the main base abstraction that all card types would be created from.
    /// </summary>
    abstract class CreditCard
    {
        /// <summary>
        /// Gets the card type.
        /// </summary>
        public abstract string CardType { get; }

        /// <summary>
        /// Gets or sets the credit limit.
        /// </summary>
        public abstract int CreditLimit { get; set; }

        /// <summary>
        /// Gets or sets the annual charge.
        /// </summary>
        public abstract int AnnualCharge { get; set; }
    }
}