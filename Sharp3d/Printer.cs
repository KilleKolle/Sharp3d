namespace Sharp3d;

public class Printer
{
    public void Print(Framebuffer framebuffer)
    {
        for (int loopY = 0; loopY < framebuffer.GetWidth(); loopY++)
        {
            for (int loopX = 0; loopX < framebuffer.GetHeight(); loopX++)
            {
                
            }
        }
    }

    private String ToAscii(Byte brightness)
    {
        switch (brightness)
        {
         case 0:
             return " ";
         case <=50:
             return "·";
         case <=100:
             return "•";
         case <=150:
             return "▪";
         case >=200:
             return "■";
        }
        return "E";
    }
}