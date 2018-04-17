using System;

namespace ShortestPathAlgorithm
{
    public class ShortestPathOps
    {
        public void Dijkstra(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for(int count = 0; count < verticesCount - 1; ++count)
            {
                int u = FindMinDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for(int v = 0; v < verticesCount; ++v)
                {
                    if(!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && (distance[u] + graph[u, v] < distance[v]))
                    {
                        distance[v] = distance[u] + graph[u, v];
                    }
                }
            }

            Print(distance, verticesCount);
        }

        private static void Print(int[] distance, int verticesCount)
        {
            Console.WriteLine("Vertex    Distance from source");

            for (int i = 0; i < verticesCount; ++i)
            {
                Console.WriteLine("{0}\t  {1}", i, distance[i]);
            }
        }

        private static int FindMinDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0; 

            // ++v will actually increment first and then return the incremented value
            // v++ will instead increment the value of v, but then return the original value that v held before being incremented
            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
    }
}