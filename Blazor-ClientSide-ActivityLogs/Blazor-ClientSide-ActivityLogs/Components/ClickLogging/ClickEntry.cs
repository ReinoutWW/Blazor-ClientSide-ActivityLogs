﻿using System.Text.Json.Serialization;

namespace Blazor_ClientSide_ActivityLogs.Components.ClickLogging;

public class ClickEntry
{
    [JsonPropertyName("route")]
    public string? Route { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonConverter(typeof(LenientStringConverter))]
    [JsonPropertyName("class")]
    public string? Class { get; set; }
    
    [JsonPropertyName("x")]
    public double X { get; set; }
    
    [JsonPropertyName("y")]
    public double Y { get; set; }
    
    [JsonPropertyName("time")]
    public DateTime Time { get; set; }
}

