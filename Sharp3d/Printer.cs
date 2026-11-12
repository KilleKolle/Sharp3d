namespace Sharp3d;

public class Printer
{
    public void Print(Framebuffer framebuffer)
    {
        //Converting every pixels brightness to ascii char
        for (int loopY = 0; loopY < framebuffer.GetHeight(); loopY++)
        {
            for (int loopX = 0; loopX < framebuffer.GetWidth(); loopX++)
            {
                Console.Write(ToSymbol(framebuffer.GetBrightness(loopX, loopY)));
            }
            Console.WriteLine();
        }
    }

    private string ToSymbol(byte brightness)
    {
        switch (brightness)
        {
            //weights are tunable, still experimental
         case 0:
             return " ";
         case <=50:
             return ".";
         case <=150:
             return ":";
         case <=200:
             return "#";
         case >200:
             return "@";
        }
    }
}