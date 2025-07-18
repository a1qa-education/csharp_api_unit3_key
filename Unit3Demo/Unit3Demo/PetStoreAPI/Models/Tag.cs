using System.Text.Json.Serialization;

namespace Unit3Demo.PetStoreAPI.Models
{
    public record Tag
    (
     [property: JsonPropertyName("id")] long? Id = null,
     [property: JsonPropertyName("name")] string? Name = null
    );
}