namespace RocketLanding;

public class LandingZone
{
    private int[,] _platform;
    public int X { get; init; }
    public int Y { get; init; }
    public int SizeX { get; init; }
    public int SizeY { get; init; }

    public LandingZone(int x, int y, int sizeX, int sizeY)
    {
        X = x;
        Y = y;
        SizeX = sizeX;
        SizeY = sizeY;
        _platform = new int[sizeX, sizeY];
    }

}