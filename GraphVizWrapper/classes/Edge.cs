using GraphVizWrapper.Interfaces;

namespace GraphVizWrapper
{
    public class Edge : Element,IEdge
    {
        public INode From {get; set;}
        public INode To { get; set; }


        public Edge()
        {

        }

        public Edge(INode From, INode To)
        {
            this.From = From;
            this.To = To;
        }



        public string GetDotString()
        {
            return From.ToString() + "->" +  To.ToString() + " "+ this.GetStyles() +  ";";
        }
    }
}
