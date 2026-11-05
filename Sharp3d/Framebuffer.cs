namespace Sharp3d;

public class Framebuffer
{
    private int _width;
    private int _height;
    private Byte[] _framebuffer;
    public Framebuffer(int width, int height)
    {
        this._width = width;
        this._height = height;
        _framebuffer = new Byte[width * height];

    }

    public void SetPixel(int x, int y, Byte brightness)
    {
        if (x < _width && y < _height)
        {
            _framebuffer[y* _width +x] = brightness;
        }
    }

    public int GetPixel(int x, int y)
    {
        if (x < _width && y < _height)  return _framebuffer[y* _width +x];
        else return -1;
    }

    public int GetHeight()
    {
        return _height;
    }

    public int GetWidth()
    {
        return _width;
    }
}