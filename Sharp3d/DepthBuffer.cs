namespace Sharp3d;

public class DepthBuffer
{
    private readonly int _width;
    private readonly int _height;
    private float[] _depthbuffer;
    public DepthBuffer(int width, int height)
    {
        this._width = width;
        this._height = height;
        _depthbuffer = new float[_width * _height];
    }

    public void SetDepth(int x, int y, float depth)
    {
        if (IsInside(x,y))
        {
            _depthbuffer[y * _width + x] = depth;
        }
    }

    public float GetDepth(int x, int y)
    {
        if (IsInside(x, y))
        {
            return _depthbuffer[y * _width +x];
        }
        throw new ArgumentOutOfRangeException(nameof(GetDepth));
    }

    public int GetWidth()
    {
        return _width;
    }

    public int GetHeight()
    {
        return _height;
    }

    public void Clear()
    {
        for (int i = 0; i < _depthbuffer.Length; i++)
        {
            _depthbuffer[i] = float.MaxValue;
        }
    }
    public bool IsInside(int x, int y)
    {
        if (x >= 0 && x < _width && y >= 0 && y < _height)
        {
            return true;
        }
        return false;
    }
    
}