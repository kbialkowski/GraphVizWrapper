using GraphVizWrapper.Interfaces;
using System.Collections.Generic;
using System.Text;


namespace GraphVizWrapper
{
    public class Graph
    {
        HashSet<INode> Nodes;
        HashSet<IEdge> Edges;

        string Shape;
        string Rankdir;

        public Graph(string shape = "record", string rankdir = "LR")
        {

            this.Nodes = new HashSet<INode>();
            this.Edges = new HashSet<IEdge>();
            this.Shape = shape;
            this.Rankdir = rankdir;
        }


        public bool AddNode(INode node)
        {

            return this.Nodes.Add(node);
        }

        public bool AddEdge(IEdge edge)
        {
            if (edge.From != null && edge.To != null && edge != null)
            {
                var fromAdd = this.AddNode(edge.From);
                var toAdd = this.AddNode(edge.To);
                var edgeAdd = this.Edges.Add(edge);
                return fromAdd || edgeAdd || toAdd;
            }
            else
            {
                return false;
            }

        }


        public override string ToString()
        {
            var output = new StringBuilder();

            output.Append("digraph G {");
            output.AppendLine("");
            output.Append("rankdir");
            output.Append("=");
            output.Append(this.Rankdir);
            output.AppendLine(";");

            output.Append("node[");
            output.Append("shape");
            output.Append("=");
            output.Append(this.Shape);
            output.Append("]");
            output.AppendLine(";");
            output.AppendLine(" ");


            output.Append("/*Nodes*/ ");
            output.AppendLine(" ");
            foreach (var node in this.Nodes)
            {

                output.AppendLine(node.GetDotString());
            }

            output.AppendLine(" ");
            output.AppendLine("/*Edges*/");
            foreach (var edge in this.Edges)
            {
                output.AppendLine(edge.GetDotString());
            }


            output.AppendLine(" ");
            output.Append("}");

            return output.ToString();
        }

    }
}
