using System.Text.Json.Serialization;

namespace WebAPI_Aula1.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {

        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
