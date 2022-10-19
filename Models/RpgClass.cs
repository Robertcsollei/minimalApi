using System.Text.Json.Serialization;

namespace Tutor.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Paladin = 1,
        Necromancer = 2,
        Druid = 3,

    }
}