namespace RocketLanding.Exceptions;

public class LandingAreaZoneAlreadyPresentException : LandingAreaException
{
    public LandingAreaZoneAlreadyPresentException() : base("There is already a landing zone present")
    {
    }
   
}