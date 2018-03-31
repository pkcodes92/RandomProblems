using System;
using System.Collections.Generic;

namespace TreeTutorial
{
    public class Tree<T>
    {
        // The root of the tree
        private TreeNode<T> root;

        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">The value of the node</param>
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">The value of the root node</param>
        /// <param name="children">The children of the root node</param>
        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>
        /// The root node or null if the tree is empty
        /// </summary>
        public TreeNode<T> Root
        {
            get { return this.root; }
        }
    }
}