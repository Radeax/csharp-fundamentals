namespace Phone
{
  public abstract class Phone
  {
    private string _versionNumber { get; set; }
    private int _batteryPercentage { get; set; }
    private string _carrier { get; set; }
    private string _ringTone { get; set; }
    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
    {
      _versionNumber = versionNumber;
      _batteryPercentage = batteryPercentage;
      _carrier = carrier;
      _ringTone = ringTone;
    }

    public abstract void DisplayInfo();
  }
}