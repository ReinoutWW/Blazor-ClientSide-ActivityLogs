using Blazor_ClientSide_ActivityLogs.Components.ClickLogging;
using Microsoft.JSInterop;
using System.Text.Json;

namespace Blazor_ClientSide_ActivityLogs.Components.ClickLogging;
public class ClickLoggerService
{
    private readonly IJSRuntime _jsRuntime;

    public ClickLoggerService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<List<ClickEntry>> GetLastFiveClicksAsync()
    {
        var resultJson = await _jsRuntime.InvokeAsync<string>(
            "localStorage.getItem", "lastFiveClicks"
        );

        if (!string.IsNullOrWhiteSpace(resultJson))
        {
            return JsonSerializer.Deserialize<List<ClickEntry>>(resultJson)
                   ?? new List<ClickEntry>();
        }
        return new List<ClickEntry>();
    }
}