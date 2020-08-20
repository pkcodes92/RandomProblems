// <copyright file = "Person.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DumpableDemo
{
    using System;

    class Person : IDumpable
    {
        readonly string name;
        public string address;
        public int phone;

        /// <summary>
        /// Creates an instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name of the person.</param>
        /// <param name="address">The address of the person.</param>
        /// <param name="phone">The phone of the person.</param>
        public Person(string name, string address, int phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        public void Dump()
        {
            Console.WriteLine("Person Details: {0}, {1}, {2}", name, address, phone);
        }
    }
}