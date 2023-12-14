using System.Text.Json.Serialization;

namespace Proyecto_SolicitudHTTP
{

    // Esta es una forma de declarar la clase para deserializar
    // public record class Repository(string name);

    // Esta es otra
    // Creo que esta es mejor ya que las propiedades de las clases deben
    // comenzar con la letra mayúscula
    public record class Repository(
        [property: JsonPropertyName("name")] string Name
    );
}
