namespace Sharp3d;

public class Framebuffer
{
    private int _width;
    private int _height;
    private uint[] _framebuffer;
    public Framebuffer(int width, int height)
    {
        //constructor
        this._width = width;
        this._height = height;
        //1 dimensional array for faster storage access
        _framebuffer = new uint[width * height];

    }

    public void SetPixel(int x, int y, byte r, byte g, byte b, byte transparency)
    {
        //checking borders
        if (x < _width && y < _height && x >= 0 && y >= 0)
        {
            // index = y * width + x | x = index % width | y = index / width (Ganzzahldivision?)
            _framebuffer[y* _width +x] = RgbToInt(r, g, b, transparency);
        }
    }

    public uint GetPixel(int x, int y)
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

    private uint RgbToInt(byte r, byte g, byte b, byte transparency)
    {
        //rr gg bb tt
            uint rgbt = ((uint)r * 10) + ((uint)g * 100) + ((uint)b * 1000) + ((uint)transparency * 10000);
            return rgbt;
    }

    public byte IntToRgb(uint rgb, uint p)
    {
        return (byte)((rgb >> (int)(p * 8)) & 0xFF);
    }

    public byte GetR(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 1);
    }

    public byte GetG(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 2);
    }

    public byte GetB(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 3);
    }

    public byte GetT(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 4);
    }
}