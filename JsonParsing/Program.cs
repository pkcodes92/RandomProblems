// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace JsonParsing
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// This is the main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method for this project.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            // Reading the file into a string
            var inputJsonText = File.ReadAllText(@"D:\\GitHub\\RandomProblems\\Test.json");

            if (inputJsonText != null)
            {
                Console.WriteLine("Input JSON text detected"); 
            }

            using (StreamReader file = File.OpenText(@"D:\\GitHub\\RandomProblems\\Test.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                RequiredResourceAccess requiredResourceAccess = (RequiredResourceAccess)serializer.Deserialize(file, typeof(RequiredResourceAccess));

                Console.WriteLine(requiredResourceAccess);
            }
        }
    }
}