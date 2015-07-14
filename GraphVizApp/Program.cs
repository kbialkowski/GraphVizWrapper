using GraphVizWrapper;
using System;

namespace GraphVizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Node nod1 = new Node("node_one");

            nod1.AddStyle("color", "red");

            Node nod2 = new Node("node_two");

            nod2.AddStyle("color", "blue");
            nod2.AddStyle("shape", "circle");

            Edge ed1 = new Edge(nod1, nod2);
            Edge ed2 = new Edge();

            Graph gr = new Graph();
            gr.AddNode(nod1);

            ed1.AddStyle("style", "solid");
            gr.AddEdge(ed1);

            Console.WriteLine(gr.ToString());

            Console.ReadKey();
            
        }
    }
}
