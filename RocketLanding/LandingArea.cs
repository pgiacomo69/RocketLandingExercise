using System.Runtime.Versioning;
using RocketLanding.Exceptions;

namespace RocketLanding;

public class LandingArea : RectangleArea
{
 
    
    public LandingZone? LandingZone { get; private set; }

    public LandingArea(int x, int y, int sizeX, int sizeY) :base (x,y,sizeX,sizeY)
    {
        SizeX = 100;
        SizeY = 100;
    }

    public void SetLandingZone(int zoneX, int zoneY, int zoneSizeX, int zoneSizeY)
    {
        if (LandingZone != null)
            throw new LandingAreaZoneAlreadyPresentException();
        if (!CheckIfCoordsInArea(zoneX,zoneY))
            throw new LandingAreaCoordsOutOfAreaException();
        if (!CheckIfCoordsInArea(zoneX+zoneSizeX-1,zoneY+zoneSizeY-1))
            throw new LandingAreaCoordsOutOfAreaException();
        LandingZone = new LandingZone(zoneX, zoneY, zoneSizeX, zoneSizeY);
    }
    
    

    public string RequestRocketLanding(int xCoord, int yCoord)
    {
        if (LandingZone == null)
            throw new LandingAreaZoneNotPresentException();
        if (!CheckIfCoordsInArea(xCoord, yCoord))
            throw new LandingAreaCoordsOutOfAreaException();
        return LandingZone.RequestRocketLanding(xCoord, yCoord);
    }
    
    
    
}