namespace Sharp3d;

public class WireframeEngine
{
    private readonly int _width;
    private readonly int _height;
    private DepthBuffer _depthbuffer;
    private FrameBuffer _frameBuffer;
    public WireframeEngine(int width, int height)
    {
        _width = width;
        _height = height;
        _frameBuffer = new FrameBuffer(_width, _height);
        _depthbuffer = new DepthBuffer( _width, _height);
    }

    public void ClearPixels()
    {
        _frameBuffer.Clear();
        _depthbuffer.Clear();
    }

    private void DrawLine(int fromX, int fromY, int toX,  int toY, byte r, byte g, byte b, byte t)
    {
        
    }

    private void ProjectTo2D()
    {
        
    }

    public void RenderFrame(World szene)
    {
    ClearPixels();    
    }
    
}