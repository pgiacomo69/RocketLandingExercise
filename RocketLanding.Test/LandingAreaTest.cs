namespace RocketLanding.Test;

public class LandingAreaTest
{
    [Fact]
    public void LandingArea_create_Ok()
    {
        int areaSizeX = 100;
        int areaSizeY = 100;
        var landingArea = new LandingArea(areaSizeX,areaSizeY);
        Assert.Equal(areaSizeX,landingArea.SizeX);
        Assert.Equal(areaSizeY,landingArea.SizeY);
    }
    
    
    [Fact]
    public void LandingArea_create_LandingZoneOk()
    {
        int areaSizeX = 100;
        int areaSizeY = 100;

        int zoneX = 5;
        int zoneY = 5;
        int zoneSizeX = 10;
        int zoneSizeY = 10;
        var landingArea = new LandingArea(areaSizeX,areaSizeY);
        landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY);
        Assert.NotNull(landingArea.LandingZone);
        Assert.Equal(zoneX,landingArea.LandingZone.X);
        Assert.Equal(zoneY,landingArea.LandingZone.Y);
        Assert.Equal(zoneSizeX,landingArea.LandingZone.SizeX);
        Assert.Equal(zoneSizeY,landingArea.LandingZone.SizeY);
    }
}
