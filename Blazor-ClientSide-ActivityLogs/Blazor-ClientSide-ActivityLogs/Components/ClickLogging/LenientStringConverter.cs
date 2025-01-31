using System.Text.Json.Serialization;
using System.Text.Json;

namespace Blazor_ClientSide_ActivityLogs.Components.ClickLogging;

public class LenientStringConverter : JsonConverter<string?>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }
        else
        {
            reader.Skip();
            return null; 
        }
    }

    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}