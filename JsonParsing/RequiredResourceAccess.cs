// <copyright file = "RequiredResourceAccess.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace JsonParsing
{
    using System.Collections.Generic;

    /// <summary>
    /// This is the required resource access object.
    /// </summary>
    public class RequiredResourceAccess
    {
        /// <summary>
        /// Gets or sets the resource app ID.
        /// </summary>
        public string ResourceAppId { get; set; }

        /// <summary>
        /// Gets or sets the list of resource access.
        /// </summary>
        public List<ResourceAccess> ResourceAccess { get; set; }
    }
}