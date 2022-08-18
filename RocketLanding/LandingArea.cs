using RocketLanding.Exceptions;

namespace RocketLanding;

public class LandingArea
{
    public int SizeX { get; init; }
    public int SizeY { get; init; }
    
    public LandingZone? LandingZone { get; private set; }

    public LandingArea(int sizeX,int sizeY)
    {
        SizeX = 100;
        SizeY = 100;
    }

    public void SetLandingZone(int zoneX, int zoneY, int zoneSizeX, int zoneSizeY)
    {
        if (LandingZone != null)
            throw new LandingAreaZoneAlreadyPresentException();
        LandingZone = new LandingZone(zoneX, zoneY, zoneSizeX, zoneSizeY);
    }


}