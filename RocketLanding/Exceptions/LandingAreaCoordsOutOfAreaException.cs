namespace RocketLanding.Exceptions;

public class LandingAreaCoordsOutOfAreaException : RocketLandingException
{
    public LandingAreaCoordsOutOfAreaException() : base("Coordinates are outside of landing Area")
    {
    }
}

