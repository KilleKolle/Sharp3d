namespace Sharp3d;

public class FrameBuffer
{
    private readonly int _width;
    private readonly int _heigth;
    private uint[] _framebuffer;
    public FrameBuffer(int width, int height)
    {
        //constructor
        this._width = width;
        this._heigth = height;
        //1 dimensional array for faster storage access
        _framebuffer = new uint[width * height];

    }

    public void SetPixel(int x, int y, byte r, byte g, byte b, byte transparency)
    {
        //checking borders
        if(x >= 0 && x < _width && y >= 0 && y < _heigth)
        {
            // index = y * width + x | x = index % width | y = index / width (Ganzzahldivision?)
            _framebuffer[y* _width +x] = RgbToInt(r, g, b, transparency);
        }
    }

    private uint GetPixel(int x, int y)
    {
        //get pixel at pos x,y
        if(x >= 0 && x < _width && y >= 0 && y < _heigth)
        {
            return _framebuffer[y * _width + x];
        }
        return 0;
    }
    
    public int GetHeigth()
    {
        return _heigth;
    }

    public int GetWidth()
    {
        return _width;
    }

    private uint RgbToInt(byte r, byte g, byte b, byte transparency)
    {
        //rr gg bb tt
        uint rgbt = 0;
            rgbt += (uint)r << (0*8);
            rgbt += (uint)g << (1*8);
            rgbt += (uint)b << (2*8);
            rgbt += (uint)transparency << (3*8);
        return rgbt;
    }

    private byte IntToRgb(uint rgb, uint p)
    {
        return (byte)((rgb >> (int)(p * 8)) & 0xFF);
    }

    public byte GetR(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 0);
    }

    public byte GetG(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 1);
    }

    public byte GetB(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 2);
    }

    public byte GetT(int x, int y)
    {
        return IntToRgb(GetPixel(x, y), 3);
    }

    public byte GetBrightness(int x, int y)
    {
        byte brightness = (byte)(0.2126 * GetR(x, y) + 0.7152 * GetG(x, y) + 0.0722 * GetB(x, y));
        return brightness;
    }
}