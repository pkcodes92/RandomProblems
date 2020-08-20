using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    /// <summary>
    /// This is the abstract class that will create credit cards.
    /// </summary>
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}