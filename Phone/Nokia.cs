namespace Phone
{
  public class Nokia : Phone, IRingable
  {
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) { }

    public string Ring()
    {

    }

    public string Unlock()
    {

    }

    public override void DisplayInfo()
    {

    }
  }
}