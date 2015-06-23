
namespace GraphVizWrapper.Interfaces
{
    public interface IEdge
    {
        INode From { get; }
        INode To { get; }
        string GetDotString();
    }
}
