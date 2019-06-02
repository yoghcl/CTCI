using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Problems
{
    public class AdjacencyList
    {
        private LinkedList<int>[] edges;

        public AdjacencyList(int numberOfVertices)
        {
            edges = new LinkedList<int>[numberOfVertices];

            //intializing the vertices
            for (int i = 0; i < numberOfVertices; i++)
            {
                edges[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int source, int destination)
        {
            edges[source].AddLast(destination);
            edges[destination].AddLast(source);
        }

        public void PrintGraph()
        {
            for (int i = 0; i < this.edges.Length; i++)
            {
                PrintNodes(edges[i].First);
            }
        }

        private void PrintNodes(LinkedListNode<int> node)
        {
            var current = node;
            while (current != null)
            {
                Console.Write(" -> " + current.Value);
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
