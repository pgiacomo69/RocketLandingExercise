namespace RocketLanding;

public class RectangleArea
{
    public int X { get; init; }
    public int Y { get; init; }
    public int SizeX { get; init; }
    public int SizeY { get; init; }

    public RectangleArea(int x, int y, int sizeX, int sizeY)
    {
        X = x;
        Y = y;
        SizeX = sizeX;
        SizeY = sizeY;
    }

    protected bool CheckIfCoordsInArea(int xCoord, int yCoord)
    {
        return (!(xCoord < X ||
                  xCoord >= X + SizeX ||
                  yCoord < Y ||
                  yCoord >= Y + SizeY));
            
    }
    
}