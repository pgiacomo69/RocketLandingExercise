namespace RocketLanding.Exceptions;

public class LandingAreaCoordsOutOfAreaException : LandingAreaException
{
    public LandingAreaCoordsOutOfAreaException() : base("Coordinates are outside of landing Area")
    {
    }
}

