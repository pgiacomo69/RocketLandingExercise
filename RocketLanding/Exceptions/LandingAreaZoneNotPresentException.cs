namespace RocketLanding.Exceptions;

public class LandingAreaZoneNotPresentException : RocketLandingException
{
    public LandingAreaZoneNotPresentException() : base("There isn't landing zone present")
    {
    }
   
}