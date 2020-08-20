// <copyright file="Tree.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace TreeTutorial
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This is the class for the tree.
    /// </summary>
    /// <typeparam name="T">The generic type for any class to be used.</typeparam>
    public class Tree<T>
    {
        // The root of the tree
        private TreeNode<T> root;

        /// <summary>
        /// Constructs the tree.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary>
        /// Constructs the tree.
        /// </summary>
        /// <param name="value">The value of the root node.</param>
        /// <param name="children">The children of the root node.</param>
        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>
        /// The root node or null if the tree is empty.
        /// </summary>
        public TreeNode<T> Root
        {
            get { return this.root; }
        }

        /// <summary>
        /// Traverses and prints tree in Depth-First-Search.
        /// (DFS) manner
        /// </summary>
        /// <param name="root">The root of the tre to be traversed.</param>
        /// <param name="spaces">The spaces used for representation of the parent-child relation.</param>
        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + " ");
            }
        }

        /// <summary>
        /// This method will traverse the tree.
        /// </summary>
        public void TraverseDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }
    }
}