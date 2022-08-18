namespace RocketLanding.Exceptions;

public class LandingAreaZoneAlreadyPresentException : RocketLandingException
{
    public LandingAreaZoneAlreadyPresentException() : base("There is already a landing zone present")
    {
    }
   
}