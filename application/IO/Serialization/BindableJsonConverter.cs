using System.Diagnostics;
using Newtonsoft.Json;
using minecraft.Application.Bindables;

namespace minecraft.Application.IO.Serialization;

/// <summary>
/// A converter used for serializing/deserializing <see cref="Bindable{T}"/> objects.
/// </summary>
internal class BindableJsonConverter : JsonConverter<ISerializableBindable>
{
    public override void WriteJson(JsonWriter writer, ISerializableBindable? value, JsonSerializer serializer)
        => value?.SerializeTo(writer, serializer);

    public override ISerializableBindable ReadJson(JsonReader reader, Type objectType, ISerializableBindable? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var bindable = existingValue ?? Activator.CreateInstance(objectType, true) as ISerializableBindable;
        Debug.Assert(bindable != null);

        bindable.DeserializeFrom(reader, serializer);

        return bindable;
    }
}
