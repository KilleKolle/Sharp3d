namespace Sharp3d;

public class Framebuffer
{
    private int _width;
    private int _height;
    private byte[] _framebuffer;
    public Framebuffer(int width, int height)
    {
        //constructor
        this._width = width;
        this._height = height;
        //1 dimensional array for faster storage access
        _framebuffer = new byte[width * height];

    }

    public void SetPixel(int x, int y, byte brightness)
    {
        //checking borders
        if (x < _width && y < _height && x >= 0 && y >= 0)
        {
            // index = y * width + x | x = index % width | y = index / width (Ganzzahldivision?)
            _framebuffer[y* _width +x] = brightness;
        }
    }

    public byte GetPixel(int x, int y)
    {
        //get pixel at pos x,y
        if (x < _width && y < _height)  return _framebuffer[y* _width +x];
        else return 0;
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