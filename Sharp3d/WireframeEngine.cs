namespace Sharp3d;

public class WireframeEngine
{
    private int _width;
    private int _height;
    private Framebuffer _framebuffer;
    public WireframeEngine(int width, int height)
    {
        _width = width;
        _height = height;
        _framebuffer = new Framebuffer(_width, _height);
    }
    
}