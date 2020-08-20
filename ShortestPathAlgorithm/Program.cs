// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ShortestPathAlgorithm
{
    using System;

    /// <summary>
    /// Pranav S. Krishnamurthy
    /// This program will outline the implementation of Dijkstra's Shortest Path Algorithm
    /// and comments are going to be made where it is appropriate.
    /// 17th April 2018
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main entry point of execution/driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            int[,] graph = {
                { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                { 0, 0, 4, 0, 10, 0, 2, 0, 0 },
                { 0, 0, 0, 14, 0, 2, 0, 1, 6 },
                { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
            };

            ShortestPathOps ops = new ShortestPathOps();

            ops.Dijkstra(graph, 0, graph.GetLength(0));

            Console.ReadKey(); 
        }
    }
}