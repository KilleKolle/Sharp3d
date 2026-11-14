using System.Drawing;

namespace Sharp3d;

public class DepthBuffer
{
    private readonly int _width;
    private readonly int _heigth;
    private float[] _depthbuffer;
    public DepthBuffer(int width, int heigth)
    {
        this._width = width;
        this._heigth = heigth;
        _depthbuffer = new float[_width * _heigth];
    }

    public void SetDepth(int x, int y, float depth)
    {
        if (x >= 0 && x < _width && y >= 0 && y < _heigth)
        {
            _depthbuffer[y * _width + x] = depth;
        }
    }

    public float GetDepth(int x, int y)
    {
        
        return _depthbuffer[y * _width +x];
    }

    public int GetWidth()
    {
        return _width;
    }

    public int GetHeigth()
    {
        return _heigth;
    }
}