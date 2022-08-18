namespace RocketLanding.Test;

public class LandingAreaTest
{


 

    [Fact]
    public void LandingArea_create_Ok()
    {
        int areaSizeX = 100;
        int areaSizeY = 100;
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
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
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY);
        Assert.NotNull(landingArea.LandingZone);
        Assert.Equal(zoneX,landingArea.LandingZone.X);
        Assert.Equal(zoneY,landingArea.LandingZone.Y);
        Assert.Equal(zoneSizeX,landingArea.LandingZone.SizeX);
        Assert.Equal(zoneSizeY,landingArea.LandingZone.SizeY);
    }
    
    [Fact]
    public void LandingArea_create_SecondLandingZoneShouldExcept()
    {
        int areaSizeX = 100;
        int areaSizeY = 100;

        int zoneX = 5;
        int zoneY = 5;
        int zoneSizeX = 10;
        int zoneSizeY = 10;
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY);
        Assert.Throws<LandingAreaZoneAlreadyPresentException>(() => landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY));
    }
    
    [Theory]
    [InlineData(-1,0,10,10)]
    [InlineData(0,-1,10,10)]
    [InlineData(0,0,101,10)]
    [InlineData(0,0,10,101)]
    public void LandingZone_create_CoordsOutsideAreaShouldExcept(int zoneX,int zoneY, int zoneSizeX,int zoneSizeY)
    {
        int areaSizeX = 100;
        int areaSizeY = 100;
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        Assert.Throws<LandingAreaCoordsOutOfAreaException>(() => landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY));
    }
    
    [Fact]
    public void LandingArea_RequestLanding_ZoneNotPresentShouldExcept()
    {
        int areaSizeX = 100;
        int areaSizeY = 100;

        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        Assert.Throws<LandingAreaZoneNotPresentException>(() => landingArea.RequestRocketLanding(10,10));
    }
    
}
