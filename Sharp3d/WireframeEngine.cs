namespace Sharp3d;

public class WireframeEngine
{
    private int _width;
    private int _height;
    private DepthBuffer _depthbuffer;
    private FrameBuffer _frameBuffer;
    public WireframeEngine(int width, int height)
    {
        _width = width;
        _height = height;
        _frameBuffer = new FrameBuffer(_width, _height);
        _depthbuffer = new DepthBuffer( _width, _height);
    }
    
}