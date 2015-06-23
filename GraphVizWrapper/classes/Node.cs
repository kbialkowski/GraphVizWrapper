using GraphVizWrapper.Interfaces;

namespace GraphVizWrapper
{
    public class Node : Element, INode
    {
        string Name;

        public Node(string name)
        {
            this.Name = name;
        }


        public override string ToString()
        {
            return this.Name;
        }

        public string GetDotString()
        {
            return this.Name + this.GetStyles(); ;
        }
    }
}
