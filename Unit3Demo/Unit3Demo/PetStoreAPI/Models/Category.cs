using System.Text.Json.Serialization;

namespace Unit3Demo.PetStoreAPI.Models
{
    public record Category
    (
     [property: JsonPropertyName("id")] long? Id = null,
     [property: JsonPropertyName("name")] string? Name = null
    );
}