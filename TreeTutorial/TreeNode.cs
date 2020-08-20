// <copyright file="TreeNode.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace TreeTutorial
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This is the class for the tree node.
    /// </summary>
    /// <typeparam name="T">The generic type for any class.</typeparam>
    public class TreeNode<T>
    {
        /// <summary>
        /// This contains the value of the node.
        /// </summary>
        private T value;

        /// <summary>
        /// Shows whether the current node has a parent or not.
        /// </summary>
        private bool hasParent;

        /// <summary>
        /// Contains the children of the node (zero or more).
        /// </summary>
        private List<TreeNode<T>> children;

        /// <summary>
        /// Constructs a tree node.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert a null value!");
            }

            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        /// <summary>
        /// The value of the node.
        /// </summary>
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// The number of the children of the nodes.
        /// </summary>
        public int ChildrenCount
        {
            get { return this.children.Count; }
        }

        /// <summary>
        /// Adds child to the node.
        /// </summary>
        /// <param name="child">The child to be added.</param>
        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert a null value!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        /// <summary>
        /// Gets the child of the node at a given index.
        /// </summary>
        /// <param name="index">The index of the desired child.</param>
        /// <returns>The child on the given position.</returns>
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}