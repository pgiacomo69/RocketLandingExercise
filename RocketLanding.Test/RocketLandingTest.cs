namespace RocketLanding;

public class RocketLandingTest
{
    [Theory]
    [InlineData(4,4)]
    [InlineData(4,5)]
    [InlineData(15,14)]
    [InlineData(14,15)]
    public void Rocket_RequestLanding_ShouldBeOutOfPlatform(int rocketX,int rocketY)
    {
        int areaSizeX = 100;
        int areaSizeY = 100;
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        int zoneX = 5;
        int zoneY = 5;
        int zoneSizeX = 10;
        int zoneSizeY = 10;
        landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY);
        Assert.Equal("out of platform",landingArea.RequestRocketLanding(rocketX,rocketY));
    }
    
    [Theory]
    [InlineData(5,5)]
    [InlineData(14,14)]
    public void Rocket_RequestLanding_ShouldBeOk(int rocketX,int rocketY)
    {
        int areaSizeX = 100;
        int areaSizeY = 100;
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        int zoneX = 5;
        int zoneY = 5;
        int zoneSizeX = 10;
        int zoneSizeY = 10;
        landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY);
        Assert.Equal("ok for landing",landingArea.RequestRocketLanding(rocketX,rocketY));
    }
    
    [Theory]
    [InlineData(5,5,6,6)]
    [InlineData(13,13,14,14)]
    [InlineData(6,6,5,5)]
    [InlineData(6,6,5,6)]
    [InlineData(6,6,5,7)]
    
    [InlineData(6,6,6,5)]
    [InlineData(6,6,6,6)]
    [InlineData(6,6,6,7)]
    
    [InlineData(6,6,7,5)]
    [InlineData(6,6,7,6)]
    [InlineData(6,6,7,7)]

    public void Rocket_RequestLanding_ShouldClash(int rocketX,int rocketY,int secondRocketX,int secondRocketY)
    {
        int areaSizeX = 100;
        int areaSizeY = 100;
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        int zoneX = 5;
        int zoneY = 5;
        int zoneSizeX = 10;
        int zoneSizeY = 10;
        landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY);
        Assert.Equal("ok for landing",landingArea.RequestRocketLanding(rocketX,rocketY));
        Assert.Equal("clash",landingArea.RequestRocketLanding(secondRocketX,secondRocketY));
    }
    
    [Theory]
    [InlineData(5,5,7,7)]
    [InlineData(12,12,14,14)]
     

    public void Rocket_RequestLanding_ShouldNotClash(int rocketX,int rocketY,int secondRocketX,int secondRocketY)
    {
        int areaSizeX = 100;
        int areaSizeY = 100;
        var landingArea = new LandingArea(0,0,areaSizeX,areaSizeY);
        int zoneX = 5;
        int zoneY = 5;
        int zoneSizeX = 10;
        int zoneSizeY = 10;
        landingArea.SetLandingZone(zoneX,zoneY,zoneSizeX,zoneSizeY);
        Assert.Equal("ok for landing",landingArea.RequestRocketLanding(rocketX,rocketY));
        Assert.Equal("ok for landing",landingArea.RequestRocketLanding(secondRocketX,secondRocketY));
    }
}
    
