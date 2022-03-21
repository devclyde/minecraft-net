using Newtonsoft.Json;
using minecraft.Application.Bindables;

namespace minecraft.Application.IO.Serialization;

/// <summary>
/// An interface which allows <see cref="Bindable{T}"/> to be json serialized/deserialized.
/// </summary>
[JsonConverter(typeof(BindableJsonConverter))]
internal interface ISerializableBindable
{
    void SerializeTo(JsonWriter writer, JsonSerializer serializer);
    void DeserializeFrom(JsonReader reader, JsonSerializer serializer);
}
