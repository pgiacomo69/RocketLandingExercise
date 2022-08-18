using System.ComponentModel;

namespace RocketLanding;

public class LandingZone :RectangleArea
{
   
    
    private int[,] _platform;
     

    public LandingZone(int x, int y, int sizeX, int sizeY) :base (x,y,sizeX,sizeY)
    {
        _platform = new int[sizeX, sizeY];
    }

    private (int,int) coordsRelativeToZone(int xCoord,int yCoord)
    {
        return (xCoord-X,yCoord - Y);
    }

    public string RequestRocketLanding(int xCoord, int yCoord)
    {
        if (!CheckIfCoordsInArea(xCoord,yCoord))
        return "out of platform";
        
        (int absX, int absY) = coordsRelativeToZone(xCoord, yCoord);
        
        if (_platform[absX, absY] != 0)
            return "clash";
        
        SetRocketLandingAndSurroundings(absX, absY);
        return "ok for landing";

    }

    private void SetRocketLandingAndSurroundings(int absX, int absY)
    {
        for (int x=absX-1;x<=absX+1;x++)
        for (int y = absY - 1; y <= absY + 1; y++)
        {
            if (x >= 0 && y >= 0 && x < SizeX && y < SizeY)
            {
                _platform[x, y] = -11;
            }
        }
        _platform[absX, absY] = 1;
    }
}