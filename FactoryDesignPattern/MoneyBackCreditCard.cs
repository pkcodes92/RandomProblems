// <copyright file="MoneyBackCreditCard.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace FactoryDesignPattern
{
    /// <summary>
    /// This class models the money back credit card - a 'ConcreteProduct' class.
    /// This class basically is one of the types that can be created.
    /// </summary>
    class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit 
        { 
           get { return _creditLimit; }
           set { _creditLimit = value; }
        }

        public override int AnnualCharge 
        {
            get { return _annualCharge; }
            set { _annualCharge = value; } 
        }
    }
}