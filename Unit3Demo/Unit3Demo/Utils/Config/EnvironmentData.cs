using System.Text.Json.Serialization;

namespace Unit3Demo.Utils.Config
{
    internal record EnvironmentData
    (
     [property: JsonPropertyName("apiUrl")] string ApiUrl,
     [property: JsonPropertyName("apiVersion")] string ApiVersion
    );
}