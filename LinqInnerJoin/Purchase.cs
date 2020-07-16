// <copyright file="Purchase.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace LinqInnerJoin
{
    /// <summary>
    /// This class represents the purchase model.
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// Gets or sets the inventory number.
        /// </summary>
        public int InvNo { get; set; }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the purchase quantity.
        /// </summary>
        public int PurQty { get; set; }
    }
}