namespace Blazor_ClientSide_ActivityLogs.Components.ClickLogging;

public class ClickEntry
{
    public string? Route { get; set; }
    public string? Class { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public DateTime Time { get; set; }
}

