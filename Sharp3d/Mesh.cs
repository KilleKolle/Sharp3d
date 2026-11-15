namespace Sharp3d;

public class Mesh
{
    private readonly Vector3[] _vectors;
    private readonly Edge[] _edges;
    public Mesh(Vector3[] vector3S, Edge[] edges)
    {
        this._vectors = vector3S;
        this._edges = edges;
    }

    public int CountVectors()
    {
        return _vectors.Length;
    }

    public int CountEdges()
    {
        return _edges.Length;
    }

    public Vector3 GetVector(int index)
    {
        if (index < CountEdges())
        {
            return _vectors[index];
        }

        throw new ArgumentOutOfRangeException(nameof(GetVector));
    }
    
    public Edge GetEdge(int index)
    {
        if (index < CountEdges())
        {
            return _edges[index];
        }

        throw new ArgumentOutOfRangeException(nameof(GetEdge));
    }
}