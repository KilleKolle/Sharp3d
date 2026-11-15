namespace Sharp3d;

public struct Edge
{
    private readonly int VecID1;
    private readonly int VecID2;
    public Edge(int vecid1, int vecid2)
    {
        this.VecID1 = vecid1;
        this.VecID2 = vecid2;
    }
}