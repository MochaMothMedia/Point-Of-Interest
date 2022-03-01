using UnityEngine;

namespace FedoraDev.PointOfInterest
{
    public interface INodeWeb
    {
        string Name { get; }
        INode[] Nodes { get; set; }
        INodeBridge[] Bridges { get; set; }
        Vector2 Offset { get; set; }
    }
}