namespace RocketLanding;

public class LandingZone :RectangleArea
{
   
    
    private int[,] _platform;
     

    public LandingZone(int x, int y, int sizeX, int sizeY) :base (x,y,sizeX,sizeY)
    {
        _platform = new int[sizeX, sizeY];
    }

    public string RequestRocketLanding(int xCoord, int yCoord)
    {
        return "";
    }
}