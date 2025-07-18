using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Unit3Demo.PetStoreAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "available")]
        Available,

        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "sold")]
        Sold
    }
}
