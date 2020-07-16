// <copyright file="ObservableListPartitioner.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DynamicPartitions
{
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// This is the class for the observable list partitioner.
    /// </summary>
    /// <typeparam name="TSource">A generic type parameter.</typeparam>
    public class OrderableListPartitioner<TSource> : OrderablePartitioner<TSource>
    {
        private readonly IList<TSource> m_input; 

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="input">The input list.</param>
        public OrderableListPartitioner(IList<TSource> input): base(true, false, true)
        {
            m_input = input;
        }

        /// <summary>
        /// Must override to return true.
        /// </summary>
        public override bool SupportsDynamicPartitions
        {
            get { return true; }
        }

        /// <summary>
        /// Gets the orderable partitions.
        /// </summary>
        /// <param name="partitionCount">An integer variable.</param>
        /// <returns>A list of key value pairs.</returns>
        public override IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount)
        {
            var dynamicPartitions = GetOrderableDynamicPartitions();
            var partitions = new IEnumerator<KeyValuePair<long, TSource>>[partitionCount];

            for (int i = 0; i < partitionCount; i++)
            {
                partitions[i] = dynamicPartitions.GetEnumerator();
            }

            return partitions;
        }

        /// <summary>
        /// Method that will get the orderable dynamic partitions.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions()
        {
            return new ListDynamicPartitions(m_input); 
        }

        private class ListDynamicPartitions: IEnumerable<KeyValuePair<long, TSource>>
        {
            private IList<TSource> m_input;
            private int m_pos = 0;

            internal ListDynamicPartitions(IList<TSource> input)
            {
                m_input = input;
            }

            public IEnumerator<KeyValuePair<long, TSource>> GetEnumerator()
            {
                while (true)
                {
                    // Each task gets the next item in the list. The index is
                    // incremented in a thread-safe manner to avoid races.
                    int elemIndex = Interlocked.Increment(ref m_pos) - 1;

                    if (elemIndex >= m_input.Count)
                    {
                        yield break;
                    }

                    yield return new KeyValuePair<long, TSource>(elemIndex, m_input[elemIndex]); 
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<KeyValuePair<long, TSource>>)this).GetEnumerator();
            }
        }
    }
}