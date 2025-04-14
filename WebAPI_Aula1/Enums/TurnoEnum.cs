using System.Text.Json.Serialization;

namespace WebAPI_Aula1.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {

        Manha,
        Tarde,
        Noite
    }
}
