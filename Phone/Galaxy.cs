namespace Phone
{
  public class Galaxy : Phone, IRingable
  {
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) { }
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