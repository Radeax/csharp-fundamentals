using System;

namespace Phone
{
  public abstract class Phone
  {
    protected string _versionNumber { get; set; }
    protected int _batteryPercentage { get; set; }
    protected string _carrier { get; set; }
    protected string _ringTone { get; set; }
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